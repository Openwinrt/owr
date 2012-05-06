#! /bin/sh
# Copyright (C) 2010-2012 Free Software Foundation, Inc.
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

# Check that $(YFLAGS) takes precedence over both $(AM_YFLAGS) and
# $(foo_YFLAGS).
# Please keep this in sync with the sister tests yflags.test, lflags.test
# and lflags2.test.

. ./defs || Exit 1

cat >fake-yacc <<'END'
#!/bin/sh
echo '/*' "$*" '*/' >y.tab.c
echo 'extern int dummy;' >> y.tab.c
END
chmod a+x fake-yacc

# Remove Yacc from the environment, so that it won't interfere
# with 'make -e' below.
unset YACC || :

cat >> configure.ac <<'END'
AC_SUBST([CXX], [false])
# Simulate presence of Yacc using our fake-yacc script.
AC_SUBST([YACC], ['$(abs_top_srcdir)'/fake-yacc])
AC_OUTPUT
END

cat > Makefile.am <<'END'
AUTOMAKE_OPTIONS = no-dependencies
bin_PROGRAMS = foo bar
foo_SOURCES = main.cc foo.yy
bar_SOURCES = main.cc bar.y++
AM_YFLAGS = __am_flags__
bar_YFLAGS = __bar_flags__
END

$ACLOCAL
$AUTOMAKE -a

grep '\$(YFLAGS).*\$(bar_YFLAGS)' Makefile.in && Exit 1
grep '\$(YFLAGS).*\$(AM_YFLAGS)' Makefile.in && Exit 1

: > foo.yy
: > bar.y++

$AUTOCONF
./configure
env YFLAGS=__user_flags__ $MAKE -e foo.cc bar-bar.c++

cat foo.cc
cat bar-bar.c++

grep '__am_flags__.*__user_flags__' foo.cc
grep '__bar_flags__.*__user_flags__' bar-bar.c++

:
