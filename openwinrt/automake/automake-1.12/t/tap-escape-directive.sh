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
#  - "escape" TODO and SKIP directives (by escaping the "#" character)

am_parallel_tests=yes
. ./defs || Exit 1

. "$am_testauxdir"/tap-setup.sh || fatal_ "sourcing tap-setup.sh"

cat > all.test <<'END'
1..2
ok \# TODO
ok \# SKIP
END

$MAKE check >stdout || { cat stdout; Exit 1; }
cat stdout

count_test_results total=2 pass=2 fail=0 xpass=0 xfail=0 skip=0 error=0

grep '^PASS: all\.test 1 .*# TODO' stdout
grep '^PASS: all\.test 2 .*# SKIP' stdout

:
