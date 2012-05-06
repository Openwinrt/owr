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

# Sanity check for the automake testsuite.
# Make sure that $am_using_tap gets automatically defined by
# './defs-static', but can be overridden by the individual tests.

. ./defs-static || exit 1

set -ex

$SHELL -c '. ./defs-static && test $am_using_tap = yes' foo.tap
$SHELL -c '. ./defs-static && test $am_using_tap = no'  foo.test
$SHELL -c '. ./defs-static && test $am_using_tap = no'  tap
$SHELL -c '. ./defs-static && test $am_using_tap = no'  tap.test
$SHELL -c '. ./defs-static && test $am_using_tap = no'  foo-tap

$SHELL -c '
  am_using_tap=no
  . ./defs-static
  test $am_using_tap = no
' foo.tap

$SHELL -c '
  am_using_tap=yes
  . ./defs-static
  test $am_using_tap = yes
' foo.test

:
