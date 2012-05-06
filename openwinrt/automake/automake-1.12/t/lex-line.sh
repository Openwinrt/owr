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

# Check that automake lex support ensures that lex-generated C
# files use correct "#line" directives.  Try also with the
# 'subdir-object' option enabled.
# See also sister test 'yacc-line.test'.

required=lex
. ./defs || Exit 1

cat >> configure.ac << 'END'
AC_CONFIG_FILES([sub/Makefile])
AC_PROG_CC
AM_PROG_CC_C_O
AC_PROG_LEX
AC_OUTPUT
END

mkdir dir sub sub/dir

cat > Makefile.am << 'END'
SUBDIRS = sub
bin_PROGRAMS = foo bar
LDADD = $(LEXLIB)
bar_LFLAGS = -v
foo_SOURCES = zardoz.l
bar_SOURCES = dir/quux.l
## Avoid spurious failures with Solaris make.
zardoz.@OBJEXT@: zardoz.c
bar-quux.@OBJEXT@: bar-quux.c
END

cat > sub/Makefile.am << 'END'
AUTOMAKE_OPTIONS = subdir-objects
noinst_PROGRAMS = foo bar
## We already used $(LEXLIB) above, so try @LEXLIB@ now.
LDADD = @LEXLIB@
foo_LFLAGS = -v
foo_SOURCES = zardoz.l
bar_SOURCES = dir/quux.l
## Avoid spurious failures with Solaris make.
foo-zardoz.@OBJEXT@: foo-zardoz.c
dir/quux.@OBJEXT@: dir/quux.c
END

cat > zardoz.l << 'END'
%{
#define YY_NO_UNISTD_H 1
%}
%%
"END"  return EOF;
.
%%
int main ()
{
  while (yylex () != EOF)
    ;
  return 0;
}

/* Avoid possible link errors. */
int yywrap (void)
{
  return 1;
}
END

cp zardoz.l dir/quux.l
cp zardoz.l sub/zardoz.l
cp zardoz.l sub/dir/quux.l

c_outputs='zardoz.c bar-quux.c sub/foo-zardoz.c sub/dir/quux.c'

$ACLOCAL
$AUTOCONF
$AUTOMAKE -a

for vpath in : false; do

  if $vpath; then
    srcdir=..
    mkdir build
    cd build
  else
    srcdir=.
  fi

  $srcdir/configure
  $MAKE

  # For debugging,
  ls -l . sub sub/dir
  $FGREP '.l' $c_outputs

  # Adjusted "#line" should not contain reference to the builddir.
  $EGREP '#.*line.*(build|\.\.).*\.l' $c_outputs && Exit 1
  # Adjusted "#line" should not contain reference to the default
  # output file names, e.g., 'lex.yy.c'.
  $EGREP '#.*line.*lex\.yy' $c_outputs && Exit 1
  # Don't be excessively strict in grepping, to avoid spurious failures.
  grep '#.*line.*zardoz\.l' zardoz.c
  grep '#.*line.*quux\.l' bar-quux.c
  grep '#.*line.*zardoz\.l' sub/foo-zardoz.c
  grep '#.*line.*quux\.l' sub/dir/quux.c
  cd $srcdir

done

:
