#! /bin/sh
# Copyright (C) 2001-2012 Free Software Foundation, Inc.
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

# Test Automake style tests.

. ./defs || Exit 1

cat > Makefile.am << 'END'
TESTS = frob.test
END

test x"$am_parallel_tests" != x"yes" || : > test-driver

: > frob.test

$ACLOCAL
$AUTOMAKE

grep 'check-TESTS.*:' Makefile.in
grep 'check-DEJAGNU' Makefile.in && Exit 1

# 'check-TESTS' is phony.
sed -n '/^\.PHONY:/,/^$/p' Makefile.in | $EGREP '(^| )check-TESTS($| )'

# 'check' should depend directly on 'check-am' (similar tests are
# in check2.test and check3.test).
$EGREP '^check:.* check-am( |$)' Makefile.in

:
