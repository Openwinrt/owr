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
#  - non-directive comments in TAP results are kept verbatim

am_parallel_tests=yes
. ./defs || Exit 1

. "$am_testauxdir"/tap-setup.sh || fatal_ "sourcing tap-setup.sh"

cat > all.test <<END
1..5
ok 1 # TDO
not ok 2 # SKP
ok #SIKP${tab}${sp}
not ok #    TOD${tab}
ok 5 # ${tab}${tab}TOOD${tab}${sp}${sp}
END

$MAKE check >stdout && { cat stdout; Exit 1; }
cat stdout

count_test_results total=5 pass=3 fail=2 xpass=0 xfail=0 skip=0 error=0

# Don't be too strict about trailing white space.
$FGREP ': all.test' stdout | sed "s/[$sp$tab]*$//" > got

cat > exp <<END
PASS: all.test 1 # TDO
FAIL: all.test 2 # SKP
PASS: all.test 3 #SIKP
FAIL: all.test 4 #    TOD
PASS: all.test 5 # ${tab}${tab}TOOD
END

cat exp
cat got
diff exp got

:
