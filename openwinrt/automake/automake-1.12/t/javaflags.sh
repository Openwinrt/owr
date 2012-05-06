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

# Check support for $(JAVACFLAGS) and $(AM_JAVACFLAGS).

. ./defs || Exit 1

cat > fake-javac <<'END'
#!/bin/sh
echo "$*" > javaflags.list
END
chmod a+x fake-javac

# Remove JAVAC from the environment, so that it won't interfere
# with 'make -e' below.
unset JAVAC || :

cat >> configure.ac <<'END'
AC_PROG_CC
# Simulate presence of the java compiler using our fake-javac script.
AC_SUBST([JAVAC], ['$(abs_top_srcdir)'/fake-javac])
AC_OUTPUT
END

cat > Makefile.am <<'END'
foodir = $(prefix)
foo_JAVA = bar.java
AM_JAVACFLAGS = __am_flags__
END

$ACLOCAL
$AUTOMAKE

grep '\$(JAVACFLAGS).*\$(AM_JAVACFLAGS)' Makefile.in && Exit 1

: > bar.java

$AUTOCONF
./configure
env JAVACFLAGS=__user_flags__ $MAKE -e

ls -l

cat javaflags.list
grep '__am_flags__.*__user_flags__' javaflags.list

:
