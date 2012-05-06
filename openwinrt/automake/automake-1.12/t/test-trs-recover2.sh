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

# Check parallel harness features:
#  - recovery from unreadable '.trs' files, in various scenarios

am_parallel_tests=yes
. ./defs || Exit 1

cat >> configure.ac <<END
AC_OUTPUT
END

cat > Makefile.am << 'END'
TESTS = foo.test bar.test
TEST_LOG_COMPILER = true
END

: > foo.test
: > bar.test

TEST_STATUS=0; export TEST_STATUS

$ACLOCAL
$AUTOCONF
$AUTOMAKE -a

./configure

: > t
chmod a-r t
test ! -r t || Exit 77
rm -f t

: Create the required log files.
$MAKE check
test -f foo.trs
test -f bar.trs

: Recreate with a sweeping "make check".
chmod a-r bar.trs
$MAKE check
test -f foo.trs
test -r foo.trs
test -f bar.trs
test -r bar.trs

: Again, this time with one .trs file missing and the other
: one unreadable.
rm -f foo.trs
chmod a-r bar.trs
$MAKE check
test -f foo.trs
test -r foo.trs
test -f bar.trs
test -r bar.trs

: Again, but using "make recheck" this time.
rm -f foo.trs
chmod a-r bar.trs
$MAKE recheck >stdout || { cat stdout; Exit 1; }
cat stdout
test -f foo.trs
test -r foo.trs
test -f bar.trs
test -r bar.trs
grep '^PASS: foo\.test' stdout
grep '^PASS: bar\.test' stdout

: More complex interactions with "make recheck" are OK.
chmod a-r bar.log bar.trs
$MAKE recheck >stdout || { cat stdout; Exit 1; }
cat stdout
test -f bar.trs
test -r bar.trs
grep '^PASS: bar\.test' stdout
grep 'foo\.test' stdout && Exit 1
count_test_results total=1 pass=1 fail=0 xpass=0 xfail=0 skip=0 error=0

: Recreate by remaking the global test log.
chmod a-r foo.trs
rm -f test-suite.log
$MAKE test-suite.log >stdout || { cat stdout; Exit 1; }
cat stdout
test -f foo.trs
test -r foo.trs
grep '^PASS: foo\.test' stdout
grep 'bar\.test' stdout && Exit 1
# Also test that have only run before should be counted in the final
# testsuite summary.
grep '^# TOTAL:  *2$' stdout

: Setup for the next check.
: > baz.test
sed 's/^TESTS =.*/& baz.test/' Makefile > t
diff t Makefile && Exit 99
mv -f t Makefile
$MAKE check
test -f foo.trs
test -f bar.trs
test -f baz.trs

: Interactions with lazy test reruns are OK.
chmod a-r foo.trs
$sleep
touch stamp
$sleep
touch bar.test
RECHECK_LOGS= $MAKE -e check >stdout || { cat stdout; Exit 1; }
cat stdout
test -r foo.trs
is_newest bar.trs bar.test
grep '^PASS: foo\.test' stdout
grep '^PASS: bar\.test' stdout
grep 'baz\.test' stdout && Exit 1
# Also test that have only run before should be counted in the final
# testsuite summary.
grep '^# TOTAL:  *3$' stdout

:
