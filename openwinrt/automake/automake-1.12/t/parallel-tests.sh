#! /bin/sh
# Copyright (C) 2009-2012 Free Software Foundation, Inc.
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

# Basic checks on parallel-tests support:
#  - console output
#  - log files, and what goes in 'test-suite.log'
#  - make clean
#  - dependencies between tests
#  - TESTS redefinition at runtime
#  - TEST_LOGS redefinition at runtime
#  - RECHECK_LOGS redefinition at runtime

am_parallel_tests=yes
. ./defs || Exit 1

cat >> configure.ac << 'END'
AC_OUTPUT
END

cat > Makefile.am << 'END'
TESTS = foo.test bar.test baz.test
XFAIL_TESTS = bar.test
foo.log: bar.log
bar.log: baz.log
END

# foo.test and bar.test sleep to ensure their logs are always strictly newer
# than the logs of their prerequisites, for HP-UX make.  The quoting pleases
# maintainer-check.
cat > foo.test <<'END'
#! /bin/sh
echo "this is $0"
sleep '1'
exit 0
END
cat > bar.test <<'END'
#! /bin/sh
echo "this is $0"
sleep '1'
exit 99
END
cat > baz.test <<'END'
#! /bin/sh
echo "this is $0"
exit 1
END
chmod a+x foo.test bar.test baz.test

$ACLOCAL
$AUTOCONF
$AUTOMAKE -a

./configure

$MAKE check >stdout && { cat stdout; Exit 1; }
cat stdout
count_test_results total=3 pass=1 fail=1 skip=0 xfail=0 xpass=0 error=1
test -f test-suite.log
cat test-suite.log
test `grep -c '^FAIL:' test-suite.log` -eq 1
test `grep -c '^ERROR:' test-suite.log` -eq 1
$EGREP '^(X?PASS|XFAIL|SKIP)' test-suite.log && Exit 1
test -f baz.log
test -f bar.log
test -f foo.log

$MAKE clean
test ! -f baz.log
test ! -f bar.log
test ! -f foo.log
test ! -f test-suite.log

# Check dependencies: baz.test needs to run before bar.test,
# but foo.test is not needed.
# Note that this usage has a problem: the summary will only
# take bar.log into account, because the $(TEST_SUITE_LOG) rule
# does not "see" baz.log.  Hmm.
env TESTS='bar.test' $MAKE -e check >stdout && { cat stdout; Exit 1; }
cat stdout
grep '^FAIL: baz\.test$' stdout
grep '^ERROR: bar\.test$' stdout

test -f baz.log
test -f bar.log
test ! -f foo.log
test -f test-suite.log

# Upon a lazy rerun, foo.test should be run, but the others shouldn't.
# Note that the lazy rerun still exits with a failure, due to the previous
# test failures.
# Note that the previous test and this one taken together expose the timing
# issue that requires the check-TESTS rule to always remove TEST_SUITE_LOG
# before running the tests lazily.
env RECHECK_LOGS= $MAKE -e check > stdout && { cat stdout; Exit 1; }
cat stdout
test -f foo.log
grep '^PASS: foo\.test$' stdout
grep bar.test stdout && Exit 1
grep baz.test stdout && Exit 1
grep '^# PASS: *1$' stdout
grep '^# FAIL: *1$' stdout
grep '^# ERROR: *1$' stdout

# Now, explicitly retry with all test logs already updated, and ensure
# that the summary is still displayed.
env RECHECK_LOGS= $MAKE -e check > stdout && { cat stdout; Exit 1; }
cat stdout
grep foo.test stdout && Exit 1
grep bar.test stdout && Exit 1
grep baz.test stdout && Exit 1
grep '^# PASS: *1$' stdout
grep '^# FAIL: *1$' stdout
grep '^# ERROR: *1$' stdout

# Lazily rerunning only foo should only rerun this one test.
env RECHECK_LOGS=foo.log $MAKE -e check > stdout && { cat stdout; Exit 1; }
cat stdout
grep foo.test stdout
grep bar.test stdout && Exit 1
grep baz.test stdout && Exit 1
grep '^# PASS: *1$' stdout
grep '^# FAIL: *1$' stdout
grep '^# ERROR: *1$' stdout

$MAKE clean
env TEST_LOGS=baz.log $MAKE -e check > stdout && { cat stdout; Exit 1; }
cat stdout
grep foo.test stdout && Exit 1
grep bar.test stdout && Exit 1
grep baz.test stdout

$MAKE clean
env TESTS=baz.test $MAKE -e check > stdout && { cat stdout; Exit 1; }
cat stdout
grep foo.test stdout && Exit 1
grep bar.test stdout && Exit 1
grep baz.test stdout

:
