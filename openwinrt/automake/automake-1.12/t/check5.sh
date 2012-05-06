#! /bin/sh
# Copyright (C) 2006-2012 Free Software Foundation, Inc.
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

# Test TESTS = $(check_PROGRAMS)

required='cc native'
. ./defs || Exit 1

cat >> configure.ac << 'END'
AC_PROG_CC
AC_OUTPUT
END

cat > Makefile.am << 'END'
check_PROGRAMS = one two
TESTS = $(check_PROGRAMS)
check-local:
	test -f one$(EXEEXT)
	test -f two$(EXEEXT)
	touch ok
.PHONY: print-tests
print-tests:
	echo BEG: $(TESTS) :END
END

$ACLOCAL
$AUTOCONF
$AUTOMAKE -a

cat > one.c << 'END'
int main (void)
{
  return 0;
}
END
cp one.c two.c

./configure
$MAKE check
test -f ok
EXEEXT=.bin $MAKE -e print-tests >stdout || { cat stdout; Exit 1; }
cat stdout
$FGREP 'BEG: one.bin two.bin :END' stdout
# No am__EXEEXT_* variable is needed.
grep '_EXEEXT_[1-9]' Makefile.in && Exit 1
$FGREP 'TESTS = $(check_PROGRAMS)' Makefile.in

:
