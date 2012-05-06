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

# Check skip summary.

. ./defs || Exit 1

cat >> configure.ac << 'END'
AC_OUTPUT
END

cat > Makefile.am << 'END'
TESTS = skip skip2
END

cat > skip <<'END'
#! /bin/sh
exit 77
END
chmod a+x skip
cp skip skip2

$ACLOCAL
$AUTOCONF
$AUTOMAKE -a

./configure

env TESTS=skip $MAKE -e check >stdout || { cat stdout; Exit 1; }
cat stdout
if test x"$am_parallel_tests" = x"yes"; then
  count_test_results total=1 pass=0 fail=0 skip=1 xfail=0 xpass=0 error=0
else
  grep '1.*passed' stdout && Exit 1
  : For shells with buggy 'set -e'.
fi

env TESTS="skip skip2" $MAKE -e check >stdout || { cat stdout; Exit 1; }
cat stdout
if test x"$am_parallel_tests" = x"yes"; then
  count_test_results total=2 pass=0 fail=0 skip=2 xfail=0 xpass=0 error=0
else
  grep '2.*passed' stdout && Exit 1
  : For shells with buggy 'set -e'.
fi

:
