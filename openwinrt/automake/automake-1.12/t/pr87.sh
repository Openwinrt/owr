#! /bin/sh
# Copyright (C) 2000-2012 Free Software Foundation, Inc.
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

# Test for PR automake/87.
# "make distcheck" fails when two source dirs exist.

required=cc
. ./defs || Exit 1

subdirs="foo bar"

for i in $subdirs; do
    mkdir $i
    unindent >$i/$i.c <<EOF
      int main (void)
      {
        return 0;
      }
EOF
    unindent >$i/Makefile.am <<EOF
      bin_PROGRAMS = $i
      ${i}_SOURCES = $i.c
EOF
done

echo "SUBDIRS = $subdirs" > Makefile.am
cat >configure.ac <<EOF
AC_INIT(`echo $subdirs | sed 's|\([a-z][a-z]*\).*|\1/\1.c|'`)
AC_CONFIG_AUX_DIR(.)
AM_INIT_AUTOMAKE($me, 1.0)
AC_PROG_CC
AC_OUTPUT(Makefile `echo $subdirs | sed 's|\([a-z][a-z]*\)|\1/Makefile|g'`)
EOF

mkdir build

$ACLOCAL
$AUTOCONF
$AUTOMAKE -a

# Regression test for bug where '.c.o:' is followed by blank line.
(while read line; do
    if test "$line" = ".c.o:"; then
       read next
       if test -z "$next"; then
	  Exit 1
       else
          : # For shells with broken 'set -e'.
       fi
       break
    fi
 done) < foo/Makefile.in || Exit 1

cd build
../configure
$MAKE distcheck

:
