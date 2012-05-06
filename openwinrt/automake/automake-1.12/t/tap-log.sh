#! /bin/sh
# Copyright (C) 2011-2012 Free Software Foundation, Inc.
#
# This program is free software; you can redistribute it and/or modify
# it under the terms of the GNU General Public License as published by
# the Free Software Foundation; either version 2, or (at your option)
# any later version.
#
# This program is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY; without even the implied warranty of
# MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
# GNU General Public License for more details.
#
# You should have received a copy of the GNU General Public License
# along with this program.  If not, see <http://www.gnu.org/licenses/>.

# TAP support:
#  - log file creation
#  - log file removal
#  - stdout and stderr of a script go in its log file
#  - TEST_SUITE_LOG redefinition, at either automake or make time
#  - VERBOSE environment variable support
# Keep in sync with 'test-log.test'.

am_parallel_tests=yes
. ./defs || Exit 1

cat > Makefile.am << 'END'
TESTS = pass.test skip.test xfail.test fail.test xpass.test error.test
TEST_SUITE_LOG = global.log
END

. "$am_testauxdir"/tap-setup.sh || fatal_ "sourcing tap-setup.sh"

# Custom markers, for use in grepping checks.
cmarker=::: # comment marker
pmarker=%%% # plain maker

cat > pass.test <<END
#! /bin/sh -e
echo 1..1
echo   "$pmarker pass $pmarker" >&2
echo "# $cmarker pass $cmarker" >&2
echo "ok 1"
END

cat > skip.test <<END
#! /bin/sh -e
echo 1..1
echo   "$pmarker skip $pmarker"
echo "# $cmarker skip $cmarker"
echo "ok 1 # SKIP"
END

cat > xfail.test <<END
#! /bin/sh -e
echo 1..1
echo   "$pmarker xfail $pmarker" >&2
echo "# $cmarker xfail $cmarker" >&2
echo "not ok 1 # TODO"
END

cat > fail.test <<END
#! /bin/sh -e
echo 1..1
echo   "$pmarker fail $pmarker"
echo "# $cmarker fail $cmarker"
echo "not ok 1"
END

cat > xpass.test <<END
#! /bin/sh -e
echo 1..1
echo   "$pmarker xpass $pmarker" >&2
echo "# $cmarker xpass $cmarker" >&2
echo "ok 1 # TODO"
END

cat > error.test <<END
#! /bin/sh -e
echo 1..1
echo   "$pmarker error $pmarker"
echo "# $cmarker error $cmarker"
echo 'Bail out!'
END

chmod a+x *.test

TEST_SUITE_LOG=my.log $MAKE -e check && Exit 1
ls -l # For debugging.
test ! -f test-suite.log
test ! -f global.log
test -f my.log
st=0
for result in pass fail xfail xpass skip error; do
  cat $result.log # For debugging.
  $FGREP "$pmarker $result $pmarker" $result.log || st=1
  $FGREP "$cmarker $result $cmarker" $result.log || st=1
done
test $st -eq 0 || Exit 1
cat my.log # For debugging.
for result in xfail fail xpass skip error; do
  cat $result.log # For debugging.
  $FGREP "$pmarker $result $pmarker" my.log || st=1
  $FGREP "$cmarker $result $cmarker" my.log || st=1
done
test `$FGREP -c "$pmarker" my.log` -eq 5
test `$FGREP -c "$cmarker" my.log` -eq 5

# Passed test scripts shouldn't be mentioned in the global log.
$EGREP '(^pass|[^x]pass)\.test' my.log && Exit 1
# But failing (expectedly or not) and skipped ones should.
$FGREP 'xfail.test' my.log
$FGREP 'skip.test' my.log
$FGREP 'fail.test' my.log
$FGREP 'xpass.test' my.log
$FGREP 'error.test' my.log

touch error2.log test-suite.log global.log
TEST_SUITE_LOG=my.log $MAKE -e mostlyclean
ls -l # For debugging.
test ! -f my.log
test ! -f pass.log
test ! -f fail.log
test ! -f xfail.log
test ! -f xpass.log
test ! -f skip.log
test ! -f error.log
# "make mostlyclean" shouldn't remove unrelated log files.
test -f error2.log
test -f test-suite.log
test -f global.log

rm -f *.log

VERBOSE=yes $MAKE check >stdout && { cat stdout; Exit 1; }
cat stdout
cat global.log
test ! -f my.log
test ! -f test-suite.log
# Check that VERBOSE causes the global testsuite log to be
# emitted on stdout.
out=`cat stdout`
log=`cat global.log`
case $out in *"$log"*) ;; *) Exit 1;; esac

touch error2.log test-suite.log my.log
$MAKE clean
ls -l # For debugging.
test ! -f global.log
test ! -f pass.log
test ! -f fail.log
test ! -f xfail.log
test ! -f xpass.log
test ! -f skip.log
test ! -f error.log
# "make clean" shouldn't remove unrelated log files.
test -f error2.log
test -f test-suite.log
test -f my.log

rm -f *.log

:
