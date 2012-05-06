#! /bin/sh
# Copyright (C) 2002-2012 Free Software Foundation, Inc.
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

# Make sure that --program-transform works.

required=cc
. ./defs || Exit 1

cat >>configure.ac <<'END'
AC_PROG_CC
AC_OUTPUT
END

cat >Makefile.am <<'EOF'
bin_PROGRAMS = h
bin_SCRIPTS = h.sh
man_MANS = h.1

.PHONY: test-install
test-install: install
	test -f inst/bin/gnu-h$(EXEEXT)
	test -f inst/bin/gnu-h.sh
	test -f inst/man/man1/gnu-h.1
EOF

cat >h.c <<'EOF'
int main (void)
{
  return 0;
}
EOF

: > h.sh
: > h.1

$ACLOCAL
$AUTOCONF
$AUTOMAKE

./configure --program-prefix=gnu- --prefix "`pwd`/inst" --mandir "`pwd`/inst/man"
$MAKE
$MAKE test-install
$MAKE uninstall
test `find inst -type f -print | wc -l` = 0

# Opportunistically test for installdirs.
rm -rf inst
$MAKE installdirs
test -d inst/bin
test -d inst/man/man1

:
