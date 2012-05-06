#! /bin/sh
# Copyright (C) 2003-2012 Free Software Foundation, Inc.
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

# If the last line of a automake-rewritten definition is made only of
# @substitutions@, automake should take care of appending an empty
# variable to make sure that line cannot end up substituted as a blank
# line (that would confuse HP-UX Make).
# These checks have been introduced in commit 'Release-1-9-254-g9d0eaef'
# into the former test 'subst2.test'.

. ./defs || Exit 1

# These are deliberately quite long, so that the xxx_PROGRAMS definition
# in Makefile.am below will be split on multiple lines, with the last
# line containing only @substituted@ stuff that expands to empty (this is
# required to expose the bug we are testing).
v1=ABCDEFGHIJKLMNOPQRSTUVWX
v2=ABCDEFGHIJKLMNOPQRSTUVWXY
v3=ABCDEFGHIJKLMNOPQRSTUVWXYZ

# Literal backslash for use by grep.
bs='\\'

cat >> configure.ac <<END
AC_SUBST([A], [''])
AC_SUBST([$v1], [''])
AC_SUBST([$v2], [''])
AC_SUBST([$v3], [''])
AC_OUTPUT
END

cat >Makefile.am <<END
AUTOMAKE_OPTIONS = no-dependencies
CC = false
EXEEXT =

## The "x" and "zardoz" strings and the use of '+=' are there to ensure
## that these variables get rewritten by Automake.
noinst_PROGRAMS = x @$v1@ @$v2@ @$v3@
bin_PROGRAMS = @A@
bin_PROGRAMS += @$v1@ @$v2@ @$v3@
check_PROGRAMS = zardoz \$(noinst_PROGRAMS)

## Required whenever there are @substituted@ values in the
## PROGRAMS primary, otherwise automake will complain.
EXTRA_PROGRAMS =

print-programs:
	@echo BEG1: \$(noinst_PROGRAMS) :END1
	@echo BEG2: \$(bin_PROGRAMS) :END2
	@echo BEG3: \$(check_PROGRAMS) :END3
END

$ACLOCAL
$AUTOCONF
$AUTOMAKE
# For debugging.
$EGREP -n 'ABCD|am__empty' Makefile.in
# Sanity check.
test `$EGREP -c "^[ $tab]*@$v2@ @$v3@[ $tab]*$bs?$" Makefile.in` -eq 3

./configure
{
  sed -n '/^noinst_PROGRAMS *=/,/[^\\]$/p' Makefile
  sed -n '/^bin_PROGRAMS *=/,/[^\\]$/p' Makefile
  sed -n '/^check_PROGRAMS *=/,/[^\\]$/p' Makefile
  sed -n '/^am__EXEEXT.*=/,/[^\\]$/p' Makefile
} >t-programs
cat t-programs
grep '^ *$' t-programs && Exit 1

$MAKE print-programs >stdout || { cat stdout; Exit 1; }
cat stdout
grep '^BEG1: x :END1$' stdout
grep '^BEG2: :END2$' stdout
grep '^BEG3: zardoz x :END3$' stdout

am__empty=X $MAKE -e print-programs >stdout || { cat stdout; Exit 1; }
cat stdout
grep '^BEG1: x X :END1$' stdout
grep '^BEG2: X :END2$' stdout
grep '^BEG3: zardoz x X :END3$' stdout

:
