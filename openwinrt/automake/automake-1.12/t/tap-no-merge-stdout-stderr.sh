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
#  - By default, TAP input is only from the stdout (and not the stderr)
#    of the test command.

am_parallel_tests=yes
. ./defs || Exit 1

cat > Makefile.am << 'END'
TEST_LOG_DRIVER_FLAGS = --comments
TESTS = all.test
END

. "$am_testauxdir"/tap-setup.sh || fatal_ "sourcing tap-setup.sh"

cat > all.test <<END
#!/bin/sh
echo 1..2
echo 'not ok' >&2
echo 'not ok 1 # TODO' >&2
echo 'ok 1'
echo '# foo foo foo'
echo '# bar bar bar' >&2
echo 'ok 44 # TODO' >&2
echo 'Bail out!' >&2
echo 'ok 2 # SKIP'
END

chmod a+x all.test

$MAKE check >stdout || { cat stdout; Exit 1; }
cat stdout

count_test_results total=2 pass=1 fail=0 xpass=0 xfail=0 skip=1 error=0
$FGREP 'foo foo foo' stdout
$FGREP 'bar bar bar' stdout && Exit 1

:
