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
#  - The Automake TAP driver has an option that instruct it to read TAP
#    input also from the stderr of the test command, not only its stdout.

am_parallel_tests=yes
. ./defs || Exit 1

fetch_tap_driver

cat > Makefile.am << 'END'
AM_TEST_LOG_DRIVER_FLAGS = --comments --merge
TESTS = all.test
END

. "$am_testauxdir"/tap-setup.sh || fatal_ "sourcing tap-setup.sh"

cat > all.test <<END
#!/bin/sh
echo 1..4
echo ok 1 >&2
echo ok 2
echo "not ok 3 # TODO" >&2
echo "ok 4 # SKIP"
echo "# foo foo foo" >&2
END
chmod a+x all.test

$MAKE check >stdout || { cat stdout; Exit 1; }
cat stdout

count_test_results total=4 pass=2 fail=0 xpass=0 xfail=1 skip=1 error=0
grep '^# all\.test: foo foo foo' stdout

cat > all.test <<END
#!/bin/sh
echo 1..1
echo ok 1
echo 'Bail out!' >&2
END

$MAKE check >stdout && { cat stdout; Exit 1; }
cat stdout

count_test_results total=2 pass=1 fail=0 xpass=0 xfail=0 skip=0 error=1

# See that the option '--no-merge' can override the effect of '--merge'.

TEST_LOG_DRIVER_FLAGS=--no-merge $MAKE -e check >stdout \
  || { cat stdout; Exit 1; }
cat stdout

count_test_results total=1 pass=1 fail=0 xpass=0 xfail=0 skip=0 error=0



:
