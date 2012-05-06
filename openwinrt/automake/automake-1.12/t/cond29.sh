#!/bin/sh
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

# Check that many conditions do not lead to combinatorial explosion.
# (This is related to PR/352.)

. ./defs || Exit 1

echo AC_PROG_CC >>configure.ac

cat >Makefile.am <<EOF
bin_PROGRAMS = a
a02_LDADD =
a03_SOURCES =
EOF

# On this test, Automake 1.7.x would compute all 2**24 = 16777216
# possible combinations of conditionals (it would do this five times,
# to define a01_DEPENDENCIES, a02_DEPENDENCIES, a03_OBJECTS,
# a04_OBJECTS, and to rewrite bin_PROGRAM), eating all memory, swap,
# or cpu time it can found.
# Limit memory available to spawned processes to ~ 150 MB.  Considering
# that 70 MB is enough for x86_64 Fedora 16, that gives tools and
# libraries plenty of room to grow.  Suggested by Jim Meyering in
# automake bug#10374.
(ulimit -v 1; sh -c ":") && skip_ "no adequate 'ulimit' builtin found"
(ulimit -v 150000; sh -c ":") || skip_ "no adequate 'ulimit' builtin found"
ulimit -v 150000

for i in \
  01 02 03 04 05 06 07 08 09 10 \
  11 12 13 14 15 16 17 18 19 20 \
  21 22 23 24
do
  unindent >>Makefile.am <<EOF
    if C$i
    bin_PROGRAMS += a$i
    a01_LDADD = foo${i}.o
    a02_LDADD += bar${i}.o
    a03_SOURCES += baz${i}.c
    a04_SOURCES = quux${i}.c
    endif C$i
EOF
  echo "AM_CONDITIONAL([C$i], [:])" >>configure.ac
done

$ACLOCAL
$AUTOMAKE

:
