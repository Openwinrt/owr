#!/bin/sh
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

# Check silent-rules mode for Yacc, when yacc-generated headers are
# involved (i.e., the '-d' option is in *YFLAGS).

required=yacc
. ./defs || Exit 1

mkdir sub

cat >>configure.ac <<'EOF'
AM_SILENT_RULES
AC_PROG_YACC
AC_PROG_CC
AC_OUTPUT
EOF

cat > Makefile.am <<'EOF'
# Need generic and non-generic rules.
AM_YFLAGS = -d
bin_PROGRAMS = foo bar
foo_SOURCES = parse.y
bar_SOURCES = $(foo_SOURCES)
bar_YFLAGS = $(AM_YFLAGS)
EOF

cat > parse.y <<'EOF'
%{
void yyerror (char *s) { return; }
int yylex (void) { return 0; }
int main (void) { return 0; }
%}
%token EOF
%%
fubar : 'f' 'o' 'o' 'b' 'a' 'r' EOF {};
EOF

$ACLOCAL
$AUTOMAKE --add-missing
$AUTOCONF

# Check that the expected non-generic rules has been truly generated.
# Otherwise, the coverage offered by this test will be weaker then
# expected and planned.
$FGREP 'bar-parse.c' Makefile.in
$FGREP '$(bar_YFLAGS)' Makefile.in

./configure --enable-silent-rules

$MAKE >stdout || { cat stdout; Exit 1; }
cat stdout

$EGREP ' (-c|-d|-o)' stdout && Exit 1
$EGREP '(mv|ylwrap) ' stdout && Exit 1

grep 'YACC  *parse\.c' stdout
grep 'updating  *parse\.h' stdout
grep 'YACC  *bar-parse\.c' stdout
grep 'updating  *bar-parse\.h' stdout

grep ' CC  *parse\.' stdout
grep ' CC  *bar-parse\.' stdout
grep 'CCLD  *foo' stdout
grep 'CCLD  *bar' stdout

# Check recovering from header removal.
rm -f parse.h bar-parse.h
$MAKE parse.h bar-parse.h >stdout || { cat stdout; Exit 1; }
cat stdout

$EGREP ' (-c|-d|-o)' stdout && Exit 1
$EGREP '(mv|ylwrap) ' stdout && Exit 1

grep 'YACC  *parse\.c' stdout
grep 'updating  *parse\.h' stdout
grep 'YACC  *bar-parse\.c' stdout
grep 'updating  *bar-parse\.h' stdout

# Cleaning and then rebuilding with the same V flag (and without
# removing the generated sources in between) shouldn't trigger a
# different set of rules.
$MAKE clean

$MAKE >stdout || { cat stdout; Exit 1; }
cat stdout

$EGREP ' (-c|-d|-o)' stdout && Exit 1
$EGREP '(mv|ylwrap) ' stdout && Exit 1

# Don't look for "YACC *.c" and "updating *.h", as yacc shouldn't
# have been re-run.
grep ' CC  *parse\.' stdout
grep ' CC  *bar-parse\.' stdout
grep 'CCLD  *foo' stdout
grep 'CCLD  *bar' stdout

# Check recovering from header removal.
rm -f parse.h bar-parse.h
$MAKE parse.h bar-parse.h >stdout || { cat stdout; Exit 1; }
cat stdout

$EGREP ' (-c|-d|-o)' stdout && Exit 1
$EGREP '(mv|ylwrap) ' stdout && Exit 1

grep 'YACC  *parse\.c' stdout
grep 'updating  *parse\.h' stdout
grep 'YACC  *bar-parse\.c' stdout
grep 'updating  *bar-parse\.h' stdout

# Ensure a truly clean rebuild.
$MAKE maintainer-clean

./configure --enable-silent-rules

$MAKE V=1 >stdout || { cat stdout; Exit 1; }
cat stdout

grep ' -c ' stdout
grep ' -o ' stdout
grep ' -d ' stdout
grep 'ylwrap ' stdout

$EGREP '(YACC|CC|CCLD) ' stdout && Exit 1

# Check recovering from header removal.
rm -f parse.h bar-parse.h
$MAKE V=1 parse.h bar-parse.h >stdout || { cat stdout; Exit 1; }
cat stdout

grep ' -d ' stdout
grep 'ylwrap ' stdout

grep 'YACC' stdout && Exit 1

# Cleaning and then rebuilding with the same V flag (and without
# removing the generated sources in between) shouldn't trigger a
# different set of rules.
$MAKE clean

$MAKE V=1 >stdout || { cat stdout; Exit 1; }
cat stdout

# Don't look for ylwrap, as probably lex hasn't been re-run.
grep ' -c ' stdout
grep ' -o ' stdout

$EGREP '(YACC|CC|CCLD) ' stdout && Exit 1

# Check recovering from header removal.
rm -f parse.h bar-parse.h
$MAKE V=1 parse.h bar-parse.h >stdout || { cat stdout; Exit 1; }
cat stdout

grep ' -d ' stdout
grep 'ylwrap ' stdout

grep 'YACC' stdout && Exit 1

:
