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

# Check that the parallel-tests driver correctly handle overrides of the
# TERM variable by either TESTS_ENVIRONMENT and AM_TESTS_ENVIRONMENT.

am_parallel_tests=yes
. ./defs || Exit 1

esc='['

# Check that grep can parse nonprinting characters.
# BSD 'grep' works from a pipe, but not a seekable file.
# GNU or BSD 'grep -a' works on files, but is not portable.
case `echo "$esc" | $FGREP "$esc"` in
  "$esc") ;;
  *) skip_ "$FGREP can't parse nonprinting characters" ;;
esac

cat >> configure.ac << 'END'
AC_OUTPUT
END

cat > Makefile.am << 'END'
AM_COLOR_TESTS = always
AUTOMAKE_OPTIONS = color-tests
TESTS = foobar
END

cat > foobar << 'END'
#!/bin/sh
echo "TERM='$TERM'"
echo "expected_term='$expected_term'"
test x"$TERM" = x"$expected_term"
END
chmod a+x foobar

mkcheck ()
{
  if env AM_COLOR_TESTS=always $* $MAKE check > stdout; then
    rc=0
  else
    rc=1
  fi
  cat stdout
  cat foobar.log
  cat test-suite.log
  return $rc
}

$ACLOCAL
$AUTOCONF
$AUTOMAKE -a
./configure

TERM=ansi; export TERM
expected_term=dumb; export expected_term
mkcheck TESTS_ENVIRONMENT='TERM=dumb'
cat stdout | grep "PASS.*foobar" | $FGREP "$esc"

TERM=dumb; export TERM
expected_term=ansi; export expected_term
mkcheck TESTS_ENVIRONMENT='TERM=ansi'
cat stdout | $FGREP "$esc" && Exit 1

TERM=ansi; export TERM
expected_term=dumb; export expected_term
mkcheck AM_TESTS_ENVIRONMENT='TERM=dumb'
cat stdout | grep "PASS.*foobar" | $FGREP "$esc"

TERM=dumb; export TERM
expected_term=ansi; export expected_term
mkcheck AM_TESTS_ENVIRONMENT='TERM=ansi'
cat stdout | $FGREP "$esc" && Exit 1

:
