//
// System.String.cs
//
// Authors:
//   Patrik Torstensson
//   Jeffrey Stedfast (fejj@ximian.com)
//   Dan Lewis (dihlewis@yahoo.co.uk)
//   Sebastien Pouliot  <sebastien@ximian.com>
//   Marek Safar (marek.safar@seznam.cz)
//   Andreas Nahr (Classdevelopment@A-SoftTech.com)
//
// (C) 2001 Ximian, Inc.  http://www.ximian.com
// Copyright (C) 2004-2005 Novell (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//
//
// This class contains all implementation for culture-insensitive methods.
// Culture-sensitive methods are implemented in the System.Globalization or
// Mono.Globalization namespace.
//
// Ensure that argument checks on methods don't overflow
//
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Security;

namespace System
{


    public sealed class String : IEnumerable, IComparable, IComparable<string>, IEquatable<string>
    {
        public static readonly string Empty = "";
        internal static readonly int LOS_limit = GetLOSLimit();

        private int length;
        private char start_char; //why not pointer ?

        [CLSCompliant(false), SecurityCritical, MethodImplAttribute(MethodImplOptions.InternalCall)]
        unsafe public extern String(char* value);


        [SecuritySafeCritical , MethodImplAttribute(MethodImplOptions.InternalCall]
        public extern String(char[] value);

        [SecuritySafeCritical , MethodImplAttribute(MethodImplOptions.InternalCall]
   		public extern String (char c, int count);

        [SecurityCritical, CLSCompliant(false) , MethodImplAttribute(MethodImplOptions.InternalCall]
    	unsafe public extern String (char *value, int startIndex, int length);

        [SecuritySafeCritical , MethodImplAttribute(MethodImplOptions.InternalCall]
       	public extern String (char [] value, int startIndex, int length);

        //Ascii
        [CLSCompliant(false), SecurityCritical, MethodImplAttribute(MethodImplOptions.InternalCall)]
        unsafe public extern String(void* value);

                //Ascii
        [CLSCompliant(false), SecurityCritical, MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern String(byte[] value);


        public static int Compare(string strA, string strB)
        {

            //FIXME Cultureinfo not in corelib
       			return CultureInfo.CurrentCulture.CompareInfo.Compare (strA, strB, CompareOptions.None);
        }

        [SecuritySafeCritical]
        public static int Compare(string strA, string strB, StringComparison comparisonType)
        {
         switch (comparisonType) {
			case StringComparison.CurrentCulture:
				return Compare (strA, strB, false, CultureInfo.CurrentCulture);
			case StringComparison.CurrentCultureIgnoreCase:
				return Compare (strA, strB, true, CultureInfo.CurrentCulture);
            //case StringComparison.InvariantCulture:
            //    return Compare (strA, strB, false, CultureInfo.InvariantCulture);
            //case StringComparison.InvariantCultureIgnoreCase:
            //    return Compare (strA, strB, true, CultureInfo.InvariantCulture);
			case StringComparison.Ordinal:
				return CompareOrdinalUnchecked (strA, 0, Int32.MaxValue, strB, 0, Int32.MaxValue);
			case StringComparison.OrdinalIgnoreCase:
				return CompareOrdinalCaseInsensitiveUnchecked (strA, 0, Int32.MaxValue, strB, 0, Int32.MaxValue);
			default:
				string msg = Locale.GetText ("Invalid value '{0}' for StringComparison", comparisonType);
				throw new ArgumentException (msg, "comparisonType");
			}
        }

        public static int Compare(string strA, int indexA, string strB, int indexB, int length)
        {
           	if ((indexA > strA.Length) || (indexB > strB.Length) || (indexA < 0) || (indexB < 0) || (length < 0))
				throw new ArgumentOutOfRangeException ();

			return CompareOrdinalUnchecked (strA, indexA, length, strB, indexB, length);

        }

        [SecuritySafeCritical]
        public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType)
        {
           	switch (comparisonType) {
			case StringComparison.CurrentCulture:
				return Compare (strA, indexA, strB, indexB, length, false, CultureInfo.CurrentCulture);
			case StringComparison.CurrentCultureIgnoreCase:
				return Compare (strA, indexA, strB, indexB, length, true, CultureInfo.CurrentCulture);
            //case StringComparison.InvariantCulture:
            //    return Compare (strA, indexA, strB, indexB, length, false, CultureInfo.InvariantCulture);
            //case StringComparison.InvariantCultureIgnoreCase:
            //    return Compare (strA, indexA, strB, indexB, length, true, CultureInfo.InvariantCulture);
			case StringComparison.Ordinal:
				return CompareOrdinal (strA, indexA, strB, indexB, length);
			case StringComparison.OrdinalIgnoreCase:
				return CompareOrdinalCaseInsensitive (strA, indexA, strB, indexB, length);
			default:
				string msg = Locale.GetText ("Invalid value '{0}' for StringComparison", comparisonType);
				throw new ArgumentException (msg, "comparisonType");
			}
        }

        public static int CompareOrdinal(string strA, string strB)
        {
          			return CompareOrdinalUnchecked (strA, 0, Int32.MaxValue, strB, 0, Int32.MaxValue);

        }

        [SecuritySafeCritical]
        public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
        {
           	if ((indexA > strA.Length) || (indexB > strB.Length) || (indexA < 0) || (indexB < 0) || (length < 0))
				throw new ArgumentOutOfRangeException ();

			return CompareOrdinalUnchecked (strA, indexA, length, strB, indexB, length);

        }

        public int CompareTo(string strB)
        {
           	if (strB == null)
				return 1;

			return Compare (this, strB);
        }

        internal static int CompareOrdinalCaseInsensitive (String strA, int indexA, String strB, int indexB, int length)
		{
			if ((indexA > strA.Length) || (indexB > strB.Length) || (indexA < 0) || (indexB < 0) || (length < 0))
				throw new ArgumentOutOfRangeException ();

			return CompareOrdinalCaseInsensitiveUnchecked (strA, indexA, length, strB, indexB, length);
		}

		internal static unsafe int CompareOrdinalUnchecked (String strA, int indexA, int lenA, String strB, int indexB, int lenB)
		{
			if (strA == null) {
				if (strB == null)
					return 0;
				else
					return -1;
			} else if (strB == null) {
				return 1;
			}
			int lengthA = Math.Min (lenA, strA.Length - indexA);
			int lengthB = Math.Min (lenB, strB.Length - indexB);

			if (lengthA == lengthB && Object.ReferenceEquals (strA, strB))
				return 0;

			fixed (char* aptr = strA, bptr = strB) {
				char* ap = aptr + indexA;
				char* end = ap + Math.Min (lengthA, lengthB);
				char* bp = bptr + indexB;
				while (ap < end) {
					if (*ap != *bp)
						return *ap - *bp;
					ap++;
					bp++;
				}
				return lengthA - lengthB;
			}
		}

		internal static unsafe int CompareOrdinalCaseInsensitiveUnchecked (String strA, int indexA, int lenA, String strB, int indexB, int lenB)
		{
			// Same as above, but checks versus uppercase characters
			if (strA == null) {
				if (strB == null)
					return 0;
				else
					return -1;
			} else if (strB == null) {
				return 1;
			}
			int lengthA = Math.Min (lenA, strA.Length - indexA);
			int lengthB = Math.Min (lenB, strB.Length - indexB);

			if (lengthA == lengthB && Object.ReferenceEquals (strA, strB))
				return 0;

			fixed (char* aptr = strA, bptr = strB) {
				char* ap = aptr + indexA;
				char* end = ap + Math.Min (lengthA, lengthB);
				char* bp = bptr + indexB;
				while (ap < end) {
					if (*ap != *bp) {
						char c1 = Char.ToUpperInvariant (*ap);
						char c2 = Char.ToUpperInvariant (*bp);
						if (c1 != c2)
							return c1 - c2;
					}
					ap++;
					bp++;
				}
				return lengthA - lengthB;
			}
		}


        public static string Concat(IEnumerable<string> values)
        {
       	if (values == null)
				throw new ArgumentNullException ("values");

			var stringList = new List<string> ();
			int len = 0;
			foreach (var v in values){
				if (v == null)
					continue;
				len += v.Length;
				stringList.Add (v);
			}
			return ConcatInternal (stringList.ToArray (), len);
        }

        public static string Concat(object arg0)
        {
          if (arg0 == null)
				return Empty;

			return arg0.ToString ();
        }

        public static string Concat(params object[] args)
        {
           if (args == null)
				throw new ArgumentNullException ("args");

			int argLen = args.Length;
			if (argLen == 0)
				return Empty;

			string [] strings = new string [argLen];
			int len = 0;
			for (int i = 0; i < argLen; i++) {
				if (args[i] != null) {
					strings[i] = args[i].ToString ();
					len += strings[i].length;
				}
			}

			return ConcatInternal (strings, len);
        }

        public static string Concat<T>(IEnumerable<T> values)
        {
            	if (values == null)
				throw new ArgumentNullException ("values");

			var stringList = new List<string> ();
			int len = 0;
			foreach (var v in values){
				string sr = v.ToString ();
				len += sr.Length;
				stringList.Add (sr);
			}
			return ConcatInternal (stringList.ToArray (), len);
        }

        public static string Concat(params string[] values)
        {
           if (values == null)
				throw new ArgumentNullException ("values");

			int len = 0;
			for (int i = 0; i < values.Length; i++) {
				String s = values[i];
				if (s != null)
					len += s.length;
			}

			return ConcatInternal (values, len);
        }

        public static string Concat(object arg0, object arg1)
        {
         		return Concat ((arg0 != null) ? arg0.ToString () : null, (arg1 != null) ? arg1.ToString () : null);

        }

        [SecuritySafeCritical]
        public static string Concat(string str0, string str1)
        {
           	if (str0 == null || str0.Length == 0) {
				if (str1 == null || str1.Length == 0)
					return Empty;
				return str1;
			}

			if (str1 == null || str1.Length == 0)
				return str0; 

			String tmp = InternalAllocateStr (str0.length + str1.length);

			fixed (char *dest = tmp, src = str0)
				CharCopy (dest, src, str0.length);
			fixed (char *dest = tmp, src = str1)
				CharCopy (dest + str0.Length, src, str1.length);

			return tmp;
        }

        public static string Concat(object arg0, object arg1, object arg2)
        {
         	string s1, s2, s3;
			if (arg0 == null)
				s1 = Empty;
			else
				s1 = arg0.ToString ();

			if (arg1 == null)
				s2 = Empty;
			else
				s2 = arg1.ToString ();

			if (arg2 == null)
				s3 = Empty;
			else
				s3 = arg2.ToString ();

			return Concat (s1, s2, s3);
        }

        [SecuritySafeCritical]
        public static string Concat(string str0, string str1, string str2)
        {
        if (str0 == null || str0.Length == 0){
				if (str1 == null || str1.Length == 0){
					if (str2 == null || str2.Length == 0)
						return Empty;
					return str2;
				} else {
					if (str2 == null || str2.Length == 0)
						return str1;
				}
				str0 = Empty;
			} else {
				if (str1 == null || str1.Length == 0){
					if (str2 == null || str2.Length == 0)
						return str0;
					else
						str1 = Empty;
				} else {
					if (str2 == null || str2.Length == 0)
						str2 = Empty;
				}
			}

			String tmp = InternalAllocateStr (str0.length + str1.length + str2.length);

			if (str0.Length != 0) {
				fixed (char *dest = tmp, src = str0) {
					CharCopy (dest, src, str0.length);
				}
			}
			if (str1.Length != 0) {
				fixed (char *dest = tmp, src = str1) {
					CharCopy (dest + str0.Length, src, str1.length);
				}
			}
			if (str2.Length != 0) {
				fixed (char *dest = tmp, src = str2) {
					CharCopy (dest + str0.Length + str1.Length, src, str2.length);
				}
			}

			return tmp;
        }

        [SecuritySafeCritical]
        public static string Concat(string str0, string str1, string str2, string str3)
        {
            return null;
        }

        		private static unsafe String ConcatInternal (String[] values, int length)
		{
			if (length == 0)
				return Empty;

			String tmp = InternalAllocateStr (length);

			fixed (char* dest = tmp) {
				int pos = 0;
				for (int i = 0; i < values.Length; i++) {
					String source = values[i];
					if (source != null) {
						fixed (char* src = source) {
							CharCopy (dest + pos, src, source.length);
						}
						pos += source.Length;
					}
				}
			}
			return tmp;
		}

        private static unsafe String ConcatInternal (String[] values, int length)
		{
			if (length == 0)
				return Empty;

			String tmp = InternalAllocateStr (length);

			fixed (char* dest = tmp) {
				int pos = 0;
				for (int i = 0; i < values.Length; i++) {
					String source = values[i];
					if (source != null) {
						fixed (char* src = source) {
							CharCopy (dest + pos, src, source.length);
						}
						pos += source.Length;
					}
				}
			}
			return tmp;
		}


        public bool Contains(string value)
        {
       	return IndexOf (value) != -1;
        }

        [SecuritySafeCritical]
        public unsafe void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            		if (destination == null)
				throw new ArgumentNullException ("destination");
			if (sourceIndex < 0)
				throw new ArgumentOutOfRangeException ("sourceIndex", "Cannot be negative");
			if (destinationIndex < 0)
				throw new ArgumentOutOfRangeException ("destinationIndex", "Cannot be negative.");
			if (count < 0)
				throw new ArgumentOutOfRangeException ("count", "Cannot be negative.");
			if (sourceIndex > Length - count)
				throw new ArgumentOutOfRangeException ("sourceIndex", "sourceIndex + count > Length");
			if (destinationIndex > destination.Length - count)
				throw new ArgumentOutOfRangeException ("destinationIndex", "destinationIndex + count > destination.Length");

			fixed (char* dest = destination, src = this)
				CharCopy (dest + destinationIndex, src + sourceIndex, count);


            
        }

        //no memcpy 8 or 16 ?
        	internal static unsafe void CharCopy (char *dest, char *src, int count) {
			// Same rules as for memcpy, but with the premise that 
			// chars can only be aligned to even addresses if their
			// enclosing types are correctly aligned
			if ((((int)(byte*)dest | (int)(byte*)src) & 3) != 0) {
				if (((int)(byte*)dest & 2) != 0 && ((int)(byte*)src & 2) != 0 && count > 0) {
					((short*)dest) [0] = ((short*)src) [0];
					dest++;
					src++;
					count--;
				}
				if ((((int)(byte*)dest | (int)(byte*)src) & 2) != 0) {
					memcpy2 ((byte*)dest, (byte*)src, count * 2);
					return;
				}
			}
			memcpy4 ((byte*)dest, (byte*)src, count * 2);
		}

        public bool EndsWith(string value)
        {
    	if (value == null)
				throw new ArgumentNullException ("value");

			return CultureInfo.CurrentCulture.CompareInfo.IsSuffix (this, value, CompareOptions.None);

        }

        [SecuritySafeCritical]
        public bool EndsWith(string value, StringComparison comparisonType)
        {
          	if (value == null)
				throw new ArgumentNullException ("value");
			if (culture == null)
				culture = CultureInfo.CurrentCulture;

			return culture.CompareInfo.IsSuffix (this, value,
				ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None);
        }

        public override bool Equals(object obj)
        {
         			return Equals (this, obj as String);
        }

        public bool Equals(string value)
        {
         	return Equals (this, value);
        }

        public static bool Equals(string a, string b)
        {
          	if ((a as object) == (b as object))
				return true;

			if (a == null || b == null)
				return false;

			int len = a.length;

			if (len != b.length)
				return false;

			fixed (char* s1 = &a.start_char, s2 = &b.start_char) {
				char* s1_ptr = s1;
				char* s2_ptr = s2;

				while (len >= 8) {
					if (((int*)s1_ptr)[0] != ((int*)s2_ptr)[0] ||
						((int*)s1_ptr)[1] != ((int*)s2_ptr)[1] ||
						((int*)s1_ptr)[2] != ((int*)s2_ptr)[2] ||
						((int*)s1_ptr)[3] != ((int*)s2_ptr)[3])
						return false;

					s1_ptr += 8;
					s2_ptr += 8;
					len -= 8;
				}

				if (len >= 4) {
					if (((int*)s1_ptr)[0] != ((int*)s2_ptr)[0] ||
						((int*)s1_ptr)[1] != ((int*)s2_ptr)[1])
						return false;

					s1_ptr += 4;
					s2_ptr += 4;
					len -= 4;
				}

				if (len > 1) {
					if (((int*)s1_ptr)[0] != ((int*)s2_ptr)[0])
						return false;

					s1_ptr += 2;
					s2_ptr += 2;
					len -= 2;
				}

				return len == 0 || *s1_ptr == *s2_ptr;
			}
        }

        [SecuritySafeCritical]
        public bool Equals(string value, StringComparison comparisonType)
        {
           	return String.Compare (value, this, comparisonType) == 0;
        }

        [SecuritySafeCritical]
        public static bool Equals(string a, string b, StringComparison comparisonType)
        {
          			return String.Compare (a, b, comparisonType) == 0;
        }

        public static string Format(string format, params object[] args)
        {
        	return Format (null, format, args);
        }

        public static string Format(IFormatProvider provider, string format, params object[] args)
        {
        			StringBuilder b = FormatHelper (null, provider, format, args);
			return b.ToString ();
        }

   	internal static StringBuilder FormatHelper (StringBuilder result, IFormatProvider provider, string format, params object[] args)
		{
			if (format == null)
				throw new ArgumentNullException ("format");
			if (args == null)
				throw new ArgumentNullException ("args");

			if (result == null) {
				/* Try to approximate the size of result to avoid reallocations */
				int i, len;

				len = 0;
				for (i = 0; i < args.Length; ++i) {
					string s = args [i] as string;
					if (s != null)
						len += s.length;
					else
						break;
				}
				if (i == args.Length)
					result = new StringBuilder (len + format.length);
				else
					result = new StringBuilder ();
			}

			int ptr = 0;
			int start = ptr;
			while (ptr < format.length) {
				char c = format[ptr ++];

				if (c == '{') {
					result.Append (format, start, ptr - start - 1);

					// check for escaped open bracket

					if (format[ptr] == '{') {
						start = ptr ++;
						continue;
					}

					// parse specifier
				
					int n, width;
					bool left_align;
					string arg_format;

					ParseFormatSpecifier (format, ref ptr, out n, out width, out left_align, out arg_format);
					if (n >= args.Length)
						throw new FormatException ("Index (zero based) must be greater than or equal to zero and less than the size of the argument list.");

					// format argument

					object arg = args[n];

					string str;
					ICustomFormatter formatter = null;
					if (provider != null)
						formatter = provider.GetFormat (typeof (ICustomFormatter))
							as ICustomFormatter;
					if (arg == null)
						str = Empty;
					else if (formatter != null)
						str = formatter.Format (arg_format, arg, provider);
					else if (arg is IFormattable)
						str = ((IFormattable)arg).ToString (arg_format, provider);
					else
						str = arg.ToString ();

					// pad formatted string and append to result

					if (width > str.length) {
						const char padchar = ' ';
						int padlen = width - str.length;

						if (left_align) {
							result.Append (str);
							result.Append (padchar, padlen);
						}
						else {
							result.Append (padchar, padlen);
							result.Append (str);
						}
					}
					else
						result.Append (str);

					start = ptr;
				}
				else if (c == '}' && ptr < format.length && format[ptr] == '}') {
					result.Append (format, start, ptr - start - 1);
					start = ptr ++;
				}
				else if (c == '}') {
					throw new FormatException ("Input string was not in a correct format.");
				}
			}

			if (start < format.length)
				result.Append (format, start, format.Length - start);

			return result;
		}
        
        [SecuritySafeCritical]
      // When modifying it, GetCaseInsensitiveHashCode() should be modified as well.
		public unsafe override int GetHashCode ()
		{
			fixed (char * c = this) {
				char * cc = c;
				char * end = cc + length - 1;
				int h = 0;
				for (;cc < end; cc += 2) {
					h = (h << 5) - h + *cc;
					h = (h << 5) - h + cc [1];
				}
				++end;
				if (cc < end)
					h = (h << 5) - h + *cc;
				return h;
			}
		}

		// Following methods are culture-insensitive
		public int IndexOf (char value)
		{
			if (this.length == 0)
				return -1;

			return IndexOfUnchecked (value, 0, this.length);
		}

      	public int IndexOf (String value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (value.length == 0)
				return 0;
			if (this.length == 0)
				return -1;
			return CultureInfo.CurrentCulture.CompareInfo.IndexOf (this, value, 0, length, CompareOptions.Ordinal);
		}

       	public int IndexOf (char value, int startIndex)
		{
			if (startIndex < 0)
				throw new ArgumentOutOfRangeException ("startIndex", "< 0");
			if (startIndex > this.length)
				throw new ArgumentOutOfRangeException ("startIndex", "startIndex > this.length");

			if ((startIndex == 0 && this.length == 0) || (startIndex == this.length))
				return -1;

			return IndexOfUnchecked (value, startIndex, this.length - startIndex);
		}

    	public int IndexOf (String value, int startIndex)
		{
			return IndexOf (value, startIndex, this.length - startIndex);
		}

        public int IndexOf(string value, StringComparison comparisonType)
        {
       		return IndexOf (value, 0, this.Length, comparisonType);
        }

        [SecuritySafeCritical]
       	public int IndexOf (char value, int startIndex, int count)
		{
			if (startIndex < 0 || startIndex > this.length)
				throw new ArgumentOutOfRangeException ("startIndex", "Cannot be negative and must be< 0");
			if (count < 0)
				throw new ArgumentOutOfRangeException ("count", "< 0");
			if (startIndex > this.length - count)
				throw new ArgumentOutOfRangeException ("count", "startIndex + count > this.length");

			if ((startIndex == 0 && this.length == 0) || (startIndex == this.length) || (count == 0))
				return -1;

			return IndexOfUnchecked (value, startIndex, count);
		}

        public int IndexOf(string value, int startIndex, int count)
        {
           if (value == null)
				throw new ArgumentNullException ("value");
			if (startIndex < 0 || startIndex > this.length)
				throw new ArgumentOutOfRangeException ("startIndex", "Cannot be negative, and should not exceed length of string.");
			if (count < 0 || startIndex > this.length - count)
				throw new ArgumentOutOfRangeException ("count", "Cannot be negative, and should point to location in string.");

			if (value.length == 0)
				return startIndex;

			if (startIndex == 0 && this.length == 0)
				return -1;

			if (count == 0)
				return -1;

			return CultureInfo.CurrentCulture.CompareInfo.IndexOf (this, value, startIndex, count);

        }

        public int IndexOf(string value, int startIndex, StringComparison comparisonType)
        {
		return IndexOf (value, startIndex, this.Length - startIndex, comparisonType);

        }

        public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType)
        {
         switch (comparisonType) {
			case StringComparison.CurrentCulture:
				return CultureInfo.CurrentCulture.CompareInfo.IndexOf (this, value, startIndex, count, CompareOptions.None);
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.IndexOf (this, value, startIndex, count, CompareOptions.IgnoreCase);
					case StringComparison.Ordinal:
				return IndexOfOrdinal (value, startIndex, count, CompareOptions.Ordinal);
			case StringComparison.OrdinalIgnoreCase:
				return IndexOfOrdinal (value, startIndex, count, CompareOptions.OrdinalIgnoreCase);
			default:
				string msg = Locale.GetText ("Invalid value '{0}' for StringComparison", comparisonType);
				throw new ArgumentException (msg, "comparisonType");
			}

        }

        
		// Following methods are culture-insensitive
        public int IndexOfAny(char[] anyOf)
        {
           	if (anyOf == null)
				throw new ArgumentNullException ();
			if (this.length == 0)
				return -1;

			return IndexOfAnyUnchecked (anyOf, 0, this.length);
        }

        public int IndexOfAny(char[] anyOf, int startIndex)
        {
         		if (anyOf == null)
				throw new ArgumentNullException ();
			if (startIndex < 0 || startIndex > this.length)
				throw new ArgumentOutOfRangeException ();

			return IndexOfAnyUnchecked (anyOf, startIndex, this.length - startIndex);
        }

        [SecuritySafeCritical]
        public int IndexOfAny(char[] anyOf, int startIndex, int count)
        {
          	if (anyOf == null)
				throw new ArgumentNullException ();
			if (startIndex < 0 || startIndex > this.length)
				throw new ArgumentOutOfRangeException ();
			if (count < 0 || startIndex > this.length - count)
				throw new ArgumentOutOfRangeException ("count", "Count cannot be negative, and startIndex + count must be less than length of the string.");

			return IndexOfAnyUnchecked (anyOf, startIndex, count);
        }

        private unsafe int IndexOfAnyUnchecked (char[] anyOf, int startIndex, int count)
		{
			if (anyOf.Length == 0)
				return -1;

			if (anyOf.Length == 1)
				return IndexOfUnchecked (anyOf[0], startIndex, count);

			fixed (char* any = anyOf) {
				int highest = *any;
				int lowest = *any;

				char* end_any_ptr = any + anyOf.Length;
				char* any_ptr = any;
				while (++any_ptr != end_any_ptr) {
					if (*any_ptr > highest) {
						highest = *any_ptr;
						continue;
					}

					if (*any_ptr < lowest)
						lowest = *any_ptr;
				}

				fixed (char* start = &start_char) {
					char* ptr = start + startIndex;
					char* end_ptr = ptr + count;

					while (ptr != end_ptr) {
						if (*ptr > highest || *ptr < lowest) {
							ptr++;
							continue;
						}

						if (*ptr == *any)
							return (int)(ptr - start);

						any_ptr = any;
						while (++any_ptr != end_any_ptr) {
							if (*ptr == *any_ptr)
								return (int)(ptr - start);
						}

						ptr++;
					}
				}
			}
			return -1;
		}

        [SecuritySafeCritical]
        public unsafe string Insert(int startIndex, string value)
        {
          if (value == null)
				throw new ArgumentNullException ("value");

			if (startIndex < 0 || startIndex > this.length)
				throw new ArgumentOutOfRangeException ("startIndex", "Cannot be negative and must be less than or equal to length of string.");

			if (value.Length == 0)
				return this;
			if (this.Length == 0)
				return value;
			String tmp = InternalAllocateStr (this.length + value.length);

			fixed (char *dest = tmp, src = this, val = value) {
				char *dst = dest;
				CharCopy (dst, src, startIndex);
				dst += startIndex;
				CharCopy (dst, val, value.length);
				dst += value.length;
				CharCopy (dst, src + startIndex, length - startIndex);
			}
			return tmp;
        }

        public static bool IsNullOrEmpty(string value)
        {
           	return (value == null) || (value.Length == 0);
        }

        public static bool IsNullOrWhiteSpace(string value)
        {
          	if ((value == null) || (value.Length == 0))
				return true;
			foreach (char c in value)
				if (!Char.IsWhiteSpace (c))
					return false;
			return true;
        }

        //internals
        	[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern static String InternalAllocateStr (int length);

        
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static string InternalIntern (string str);

		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static string InternalIsInterned (string str);

        public static string Join(string separator, IEnumerable<string> values)
        {
          	if (separator == null)
				return Concat (values);
			
			if (values == null)
				throw new ArgumentNullException ("values");
			
			var stringList = new List<string> ();
			foreach (var v in values)
				stringList.Add (v);

			return JoinUnchecked (separator, stringList.ToArray (), 0, stringList.Count);
        }

        public static string Join(string separator, params object[] values)
        {
if (separator == null)
				return Concat (values);
			
			if (values == null)
				throw new ArgumentNullException ("values");

			var strCopy = new string [values.Length];
			int i = 0;
			foreach (var v in values)
				strCopy [i++] = v.ToString ();

			return JoinUnchecked (separator, strCopy, 0, strCopy.Length);
        }

        public static string Join(string separator, params string[] value)
        {
           	if (value == null)
				throw new ArgumentNullException ("value");
			if (separator == null)
				separator = Empty;

			return JoinUnchecked (separator, value, 0, value.Length);
        }

        public static string Join<T>(string separator, IEnumerable<T> values)
        {
         	if (separator == null)
				return Concat<T> (values);
				
			if (values == null)
				throw new ArgumentNullException ("values");
			
			var stringList = new List<string> ();
			foreach (var v in values)
				stringList.Add (v.ToString ());

			return JoinUnchecked (separator, stringList.ToArray (), 0, stringList.Count);
        }

        [SecuritySafeCritical]
        public static string Join(string separator, string[] value, int startIndex, int count)
        {
           if (value == null)
				throw new ArgumentNullException ("value");
			if (startIndex < 0)
				throw new ArgumentOutOfRangeException ("startIndex", "< 0");
			if (count < 0)
				throw new ArgumentOutOfRangeException ("count", "< 0");
			if (startIndex > value.Length - count)
				throw new ArgumentOutOfRangeException ("startIndex", "startIndex + count > value.length");

			if (startIndex == value.Length)
				return Empty;
			if (separator == null)
				separator = Empty;

			return JoinUnchecked (separator, value, startIndex, count);
        }

        private static unsafe string JoinUnchecked (string separator, string[] value, int startIndex, int count)
		{
			// Unchecked parameters
			// startIndex, count must be >= 0; startIndex + count must be <= value.length
			// separator and value must not be null

			int length = 0;
			int maxIndex = startIndex + count;
			// Precount the number of characters that the resulting string will have
			for (int i = startIndex; i < maxIndex; i++) {
				String s = value[i];
				if (s != null)
					length += s.length;
			}
			length += separator.length * (count - 1);
			if (length <= 0)
				return Empty;

			String tmp = InternalAllocateStr (length);

			maxIndex--;
			fixed (char* dest = tmp, sepsrc = separator) {
				// Copy each string from value except the last one and add a separator for each
				int pos = 0;
				for (int i = startIndex; i < maxIndex; i++) {
					String source = value[i];
					if (source != null) {
						if (source.Length > 0) {
							fixed (char* src = source)
								CharCopy (dest + pos, src, source.Length);
							pos += source.Length;
						}
					}
					if (separator.Length > 0) {
						CharCopy (dest + pos, sepsrc, separator.Length);
						pos += separator.Length;
					}
				}
				// Append last string that does not get an additional separator
				String sourceLast = value[maxIndex];
				if (sourceLast != null) {
					if (sourceLast.Length > 0) {
						fixed (char* src = sourceLast)
							CharCopy (dest + pos, src, sourceLast.Length);
					}
				}
			}
			return tmp;
		}


        public int LastIndexOf(char value)
        {
       	if (this.length == 0)
				return -1;
			
			return LastIndexOfUnchecked (value, this.length - 1, this.length);
        }

        public int LastIndexOf(string value)
        {
        	return LastIndexOf (value, this.length - 1, this.length);
        }

        public int LastIndexOf(char value, int startIndex)
        {
    	return LastIndexOf (value, startIndex, startIndex + 1);
        }

        public int LastIndexOf(string value, int startIndex)
        {
         	int max = startIndex;
			if (max < this.Length)
				max++;
			return LastIndexOf (value, startIndex, max);
        }

        public int LastIndexOf(string value, StringComparison comparisonType)
        {
       	if (this.Length == 0)
				return value.Length == 0 ? 0 : -1;
			else
				return LastIndexOf (value, this.Length - 1, this.Length, comparisonType);
        }

        [SecuritySafeCritical]
        public int LastIndexOf(char value, int startIndex, int count)
        {
     	if (this.length == 0)
				return -1;
 
			// >= for char (> for string)
			if ((startIndex < 0) || (startIndex >= this.Length))
				throw new ArgumentOutOfRangeException ("startIndex", "< 0 || >= this.Length");
			if ((count < 0) || (count > this.Length))
				throw new ArgumentOutOfRangeException ("count", "< 0 || > this.Length");
			if (startIndex - count + 1 < 0)
				throw new ArgumentOutOfRangeException ("startIndex - count + 1 < 0");

			return LastIndexOfUnchecked (value, startIndex, count);
        }

        public int LastIndexOf(string value, int startIndex, int count)
        {
        if (value == null)
				throw new ArgumentNullException ("value");

			if (this.length == 0)
				return value.Length == 0 ? 0 : -1;
			// -1 > startIndex > for string (0 > startIndex >= for char)
			if ((startIndex < -1) || (startIndex > this.Length))
				throw new ArgumentOutOfRangeException ("startIndex", "< 0 || > this.Length");
			if ((count < 0) || (count > this.Length))
				throw new ArgumentOutOfRangeException ("count", "< 0 || > this.Length");
			if (startIndex - count + 1 < 0)
				throw new ArgumentOutOfRangeException ("startIndex - count + 1 < 0");

			if (value.Length == 0)
				return Math.Min (this.Length - 1, startIndex);

			if (startIndex == 0 && this.length == 0)
				return -1;

			// This check is needed to match undocumented MS behaviour
			if (this.length == 0 && value.length > 0)
				return -1;

			if (count == 0)
				return -1;

			if (startIndex == this.Length)
				startIndex--;
			return CultureInfo.CurrentCulture.CompareInfo.LastIndexOf (this, value, startIndex, count);

        }

        public int LastIndexOf(string value, int startIndex, StringComparison comparisonType)
        {
          	return LastIndexOf (value, startIndex, startIndex + 1, comparisonType);
        }

        public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType)
        {
         switch (comparisonType) {
			case StringComparison.CurrentCulture:
				return CultureInfo.CurrentCulture.CompareInfo.LastIndexOf (this, value, startIndex, count, CompareOptions.None);
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.LastIndexOf (this, value, startIndex, count, CompareOptions.IgnoreCase);
					case StringComparison.Ordinal:
				return LastIndexOfOrdinal (value, startIndex, count, CompareOptions.Ordinal);
			case StringComparison.OrdinalIgnoreCase:
				return LastIndexOfOrdinal (value, startIndex, count, CompareOptions.OrdinalIgnoreCase);
			default:
				string msg = Locale.GetText ("Invalid value '{0}' for StringComparison", comparisonType);
				throw new ArgumentException (msg, "comparisonType");
			}
        }

        public int LastIndexOfAny(char[] anyOf)
        {
        {
			if (anyOf == null)
				throw new ArgumentNullException ();
			if (this.length == 0)
				return -1;

			return LastIndexOfAnyUnchecked (anyOf, this.length - 1, this.length);
        }

        public int LastIndexOfAny(char[] anyOf, int startIndex)
        {
       if (anyOf == null)
				throw new ArgumentNullException ();
			if (this.length == 0)
				return -1;

			if (startIndex < 0 || startIndex >= this.length)
				throw new ArgumentOutOfRangeException ("startIndex", "Cannot be negative, and should be less than length of string.");

			if (this.length == 0)
				return -1;

			return LastIndexOfAnyUnchecked (anyOf, startIndex, startIndex + 1);
        }

        [SecuritySafeCritical]
        public int LastIndexOfAny(char[] anyOf, int startIndex, int count)
        {
       	if (anyOf == null) 
				throw new ArgumentNullException ();
			if (this.length == 0)
				return -1;

			if ((startIndex < 0) || (startIndex >= this.Length))
				throw new ArgumentOutOfRangeException ("startIndex", "< 0 || > this.Length");
			if ((count < 0) || (count > this.Length))
				throw new ArgumentOutOfRangeException ("count", "< 0 || > this.Length");
			if (startIndex - count + 1 < 0)
				throw new ArgumentOutOfRangeException ("startIndex - count + 1 < 0");

			if (this.length == 0)
				return -1;

			return LastIndexOfAnyUnchecked (anyOf, startIndex, count);
        }

        public static bool operator ==(string a, string b)
        {
 			return Equals (a, b);
        }

        public static bool operator !=(string a, string b)
        {
   		return !Equals (a, b);
        }

        public string PadLeft(int totalWidth)
        {
        		return PadLeft (totalWidth, ' ');
        }

        public string PadLeft(int totalWidth, char paddingChar)
        {
   	//LAMESPEC: MSDN Doc says this is reversed for RtL languages, but this seems to be untrue

			if (totalWidth < 0)
				throw new ArgumentOutOfRangeException ("totalWidth", "< 0");

			if (totalWidth < this.length)
				return this;
			if (totalWidth == 0)
				return Empty;

			String tmp = InternalAllocateStr (totalWidth);

			fixed (char* dest = tmp, src = this) {
				char* padPos = dest;
				char* padTo = dest + (totalWidth - length);
				while (padPos != padTo)
					*padPos++ = paddingChar;

				CharCopy (padTo, src, length);
			}
			return tmp;
        }

        public string PadRight(int totalWidth)
        {
           		return PadRight (totalWidth, ' ');
        }

        public string PadRight(int totalWidth, char paddingChar)
        {
         	//LAMESPEC: MSDN Doc says this is reversed for RtL languages, but this seems to be untrue

			if (totalWidth < 0)
				throw new ArgumentOutOfRangeException ("totalWidth", "< 0");

			if (totalWidth < this.length)
				return this;
			if (totalWidth == 0)
				return Empty;

			String tmp = InternalAllocateStr (totalWidth);

			fixed (char* dest = tmp, src = this) {
				CharCopy (dest, src, length);

				char* padPos = dest + length;
				char* padTo = dest + totalWidth;
				while (padPos != padTo)
					*padPos++ = paddingChar;
			}
			return tmp;
        }

        public string Remove(int startIndex)
        {
      	if (startIndex < 0)
				throw new ArgumentOutOfRangeException ("startIndex", "StartIndex can not be less than zero");
			if (startIndex >= this.length)
				throw new ArgumentOutOfRangeException ("startIndex", "StartIndex must be less than the length of the string");

			return Remove (startIndex, this.length - startIndex);
        }

        [SecuritySafeCritical]
        public unsafe string Remove(int startIndex, int count)
        {
         if (startIndex < 0)
				throw new ArgumentOutOfRangeException ("startIndex", "Cannot be negative.");
			if (count < 0)
				throw new ArgumentOutOfRangeException ("count", "Cannot be negative.");
			if (startIndex > this.length - count)
				throw new ArgumentOutOfRangeException ("count", "startIndex + count > this.length");

			String tmp = InternalAllocateStr (this.length - count);

			fixed (char *dest = tmp, src = this) {
				char *dst = dest;
				CharCopy (dst, src, startIndex);
				int skip = startIndex + count;
				dst += startIndex;
				CharCopy (dst, src + skip, length - skip);
			}
			return tmp;
        }

        internal static unsafe void CharCopy (char *dest, char *src, int count) {
			// Same rules as for memcpy, but with the premise that 
			// chars can only be aligned to even addresses if their
			// enclosing types are correctly aligned
			if ((((int)(byte*)dest | (int)(byte*)src) & 3) != 0) {
				if (((int)(byte*)dest & 2) != 0 && ((int)(byte*)src & 2) != 0 && count > 0) {
					((short*)dest) [0] = ((short*)src) [0];
					dest++;
					src++;
					count--;
				}
				if ((((int)(byte*)dest | (int)(byte*)src) & 2) != 0) {
					memcpy2 ((byte*)dest, (byte*)src, count * 2);
					return;
				}
			}
			memcpy4 ((byte*)dest, (byte*)src, count * 2);
		}

        public string Replace(char oldChar, char newChar)
        {
      // LAMESPEC: According to MSDN the following method is culture-sensitive but this seems to be incorrect
			// LAMESPEC: Result is undefined if result length is longer than maximum string length

			if (oldValue == null)
				throw new ArgumentNullException ("oldValue");

			if (oldValue.Length == 0)
				throw new ArgumentException ("oldValue is the empty string.");

			if (this.Length == 0)
				return this;
			
			if (newValue == null)
				newValue = Empty;

			return ReplaceUnchecked (oldValue, newValue);
		}
       
        private unsafe String ReplaceUnchecked (String oldValue, String newValue)
		{
			if (oldValue.length > length)
				return this;
			if (oldValue.length == 1 && newValue.length == 1) {
				return Replace (oldValue[0], newValue[0]);
				// ENHANCE: It would be possible to special case oldValue.length == newValue.length
				// because the length of the result would be this.length and length calculation unneccesary
			}

			const int maxValue = 200; // Allocate 800 byte maximum
			int* dat = stackalloc int[maxValue];
			fixed (char* source = this, replace = newValue) {
				int i = 0, count = 0;
				while (i < length) {
					int found = IndexOfOrdinalUnchecked (oldValue, i, length - i);
					if (found < 0)
						break;
					else {
						if (count < maxValue)
							dat[count++] = found;
						else
							return ReplaceFallback (oldValue, newValue, maxValue);
					}
					i = found + oldValue.length;
				}
				if (count == 0)
					return this;
				int nlen = this.length + ((newValue.length - oldValue.length) * count);
				String tmp = InternalAllocateStr (nlen);

				int curPos = 0, lastReadPos = 0;
				fixed (char* dest = tmp) {
					for (int j = 0; j < count; j++) {
						int precopy = dat[j] - lastReadPos;
						CharCopy (dest + curPos, source + lastReadPos, precopy);
						curPos += precopy;
						lastReadPos = dat[j] + oldValue.length;
						CharCopy (dest + curPos, replace, newValue.length);
						curPos += newValue.length;
					}
					CharCopy (dest + curPos, source + lastReadPos, length - lastReadPos);
				}
				return tmp;
			}
		}


        public string Replace(string oldValue, string newValue)
        {
        	// LAMESPEC: According to MSDN the following method is culture-sensitive but this seems to be incorrect
			// LAMESPEC: Result is undefined if result length is longer than maximum string length

			if (oldValue == null)
				throw new ArgumentNullException ("oldValue");

			if (oldValue.Length == 0)
				throw new ArgumentException ("oldValue is the empty string.");

			if (this.Length == 0)
				return this;
			
			if (newValue == null)
				newValue = Empty;

			return ReplaceUnchecked (oldValue, newValue);
        }

        public string[] Split(params char[] separator)
        {
           	return Split (separator, int.MaxValue, 0);
        }

        public string[] Split(char[] separator, int count)
        {
         	return Split (separator, count, 0);
        }

        public string[] Split(char[] separator, StringSplitOptions options)
        {
        	return Split (separator, Int32.MaxValue, options);
        }

        public string[] Split(string[] separator, StringSplitOptions options)
        {
          	return Split (separator, Int32.MaxValue, options);
        }

        public string[] Split(char[] separator, int count, StringSplitOptions options)
        {
          	if (count < 0)
				throw new ArgumentOutOfRangeException ("count", "Count cannot be less than zero.");
			if ((options != StringSplitOptions.None) && (options != StringSplitOptions.RemoveEmptyEntries))
				throw new ArgumentException ("Illegal enum value: " + options + ".");

			if (Length == 0 && (options & StringSplitOptions.RemoveEmptyEntries) != 0)
				return new String[0];

			if (count <= 1) {
				return count == 0 ?
					new String[0] :
					new String[1] { this };
			}

			return SplitByCharacters (separator, count, options != 0);
        }

        public string[] Split(string[] separator, int count, StringSplitOptions options)
        {
           if (count < 0)
				throw new ArgumentOutOfRangeException ("count", "Count cannot be less than zero.");
			if ((options != StringSplitOptions.None) && (options != StringSplitOptions.RemoveEmptyEntries))
				throw new ArgumentException ("Illegal enum value: " + options + ".");

			if (count <= 1) {
				return count == 0 ?
					new String[0] :
					new String[1] { this };
			}

			bool removeEmpty = (options & StringSplitOptions.RemoveEmptyEntries) != 0;

			if (separator == null || separator.Length == 0)
				return SplitByCharacters (null, count, removeEmpty);

			if (Length == 0 && removeEmpty)
				return new String [0];

			List<String> arr = new List<String> ();

			int pos = 0;
			int matchCount = 0;
			while (pos < this.Length) {
				int matchIndex = -1;
				int matchPos = Int32.MaxValue;

				// Find the first position where any of the separators matches
				for (int i = 0; i < separator.Length; ++i) {
					string sep = separator [i];
					if (sep == null || sep.Length == 0)
						continue;

					int match = IndexOfOrdinalUnchecked (sep, pos, length - pos);
					if (match >= 0 && match < matchPos) {
						matchIndex = i;
						matchPos = match;
					}
				}

				if (matchIndex == -1)
					break;

				if (!(matchPos == pos && removeEmpty)) {
					if (arr.Count == count - 1)
						break;
					arr.Add (this.Substring (pos, matchPos - pos));
				}

				pos = matchPos + separator [matchIndex].Length;

				matchCount ++;
			}

			if (matchCount == 0)
				return new String [] { this };

			// string contained only separators
			if (removeEmpty && matchCount != 0 && pos == this.Length && arr.Count == 0)
				return new String [0];

			if (!(removeEmpty && pos == this.Length))
				arr.Add (this.Substring (pos));

			return arr.ToArray ();
        }

        	unsafe string[] SplitByCharacters (char[] sep, int count, bool removeEmpty)
		{


			int[] split_points = null;
			int total_points = 0;
			--count;

			if (sep == null || sep.Length == 0) {
				fixed (char* src = this) {
					char* src_ptr = src;
					int len = Length;

					do {
						if (char.IsWhiteSpace (*src_ptr++)) {
							if (split_points == null) {
								split_points = new int[8];
							} else if (split_points.Length == total_points) {
								Array.Resize (ref split_points, split_points.Length * 2);
							}

							split_points[total_points++] = Length - len;
							if (total_points == count && !removeEmpty)
								break;
						}
					} while (len-- != 0);
				}
			} else {
				fixed (char* src = this) {
					fixed (char* sep_src = sep) {
						char* src_ptr = src;
						char* sep_ptr_end = sep_src + sep.Length;
						int len = Length;
						do {
							char* sep_ptr = sep_src;
							do {
								if (*sep_ptr++ == *src_ptr) {
									if (split_points == null) {
										split_points = new int[8];
									} else if (split_points.Length == total_points) {
										Array.Resize (ref split_points, split_points.Length * 2);
									}

									split_points[total_points++] = Length - len;
									if (total_points == count && !removeEmpty)
										len = 0;

									break;
								}
							} while (sep_ptr != sep_ptr_end);

							++src_ptr;
						} while (len-- != 0);
					}
				}
			}

			if (total_points == 0)
				return new string[] { this };

			var res = new string[Math.Min (total_points, count) + 1];
			int prev_index = 0;
			int i = 0;
			if (!removeEmpty) {
				for (; i < total_points; ++i) {
					var start = split_points[i];
					res[i] = SubstringUnchecked (prev_index, start - prev_index);
					prev_index = start + 1;
				}

				res[i] = SubstringUnchecked (prev_index, Length - prev_index);
			} else {
				int used = 0;
				int length;
				for (; i < total_points; ++i) {
					var start = split_points[i];
					length = start - prev_index;
					if (length != 0) {
						if (used == count)
							break;

						res[used++] = SubstringUnchecked (prev_index, length);
					}

					prev_index = start + 1;
				}

				length = Length - prev_index;
				if (length != 0)
					res[used++] = SubstringUnchecked (prev_index, length);

				if (used != res.Length)
					Array.Resize (ref res, used);
			}

			return res;
		}

        public bool StartsWith(string value)
        {
     	if (value == null)
				throw new ArgumentNullException ("value");

			return CultureInfo.CurrentCulture.CompareInfo.IsPrefix (this, value, CompareOptions.None);

        }

        [SecuritySafeCritical]
        public bool StartsWith(string value, StringComparison comparisonType)
        {
	if (value == null)
				throw new ArgumentNullException ("value");

			switch (comparisonType) {
			case StringComparison.CurrentCulture:
				return CultureInfo.CurrentCulture.CompareInfo.IsPrefix (this, value, CompareOptions.None);
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.IsPrefix (this, value, CompareOptions.IgnoreCase);
			case StringComparison.InvariantCulture:
				return CultureInfo.InvariantCulture.CompareInfo.IsPrefix (this, value, CompareOptions.None);
			case StringComparison.InvariantCultureIgnoreCase:
				return CultureInfo.InvariantCulture.CompareInfo.IsPrefix (this, value, CompareOptions.IgnoreCase);
			case StringComparison.Ordinal:
				return CultureInfo.CurrentCulture.CompareInfo.IsPrefix (this, value, CompareOptions.Ordinal);
			case StringComparison.OrdinalIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.IsPrefix (this, value, CompareOptions.OrdinalIgnoreCase);
			default:
				string msg = Locale.GetText ("Invalid value '{0}' for StringComparison", comparisonType);
				throw new ArgumentException (msg, "comparisonType");
			}
        }

        public string Substring(int startIndex)
        {
 	if (startIndex == 0)
				return this;
			if (startIndex < 0 || startIndex > this.length)
				throw new ArgumentOutOfRangeException ("startIndex");

			return SubstringUnchecked (startIndex, this.length - startIndex);
        }

        [SecuritySafeCritical]
        public string Substring(int startIndex, int length)
        {
          	if (length < 0)
				throw new ArgumentOutOfRangeException ("length", "Cannot be negative.");
			if (startIndex < 0)
				throw new ArgumentOutOfRangeException ("startIndex", "Cannot be negative.");
			if (startIndex > this.length)
				throw new ArgumentOutOfRangeException ("startIndex", "Cannot exceed length of string.");
			if (startIndex > this.length - length)
				throw new ArgumentOutOfRangeException ("length", "startIndex + length cannot exceed length of string.");
			if (startIndex == 0 && length == this.length)
				return this;

			return SubstringUnchecked (startIndex, length);
        }

        // This method is used by StringBuilder.ToString() and is expected to
		// always create a new string object (or return String.Empty). 
		internal unsafe String SubstringUnchecked (int startIndex, int length)
		{
			if (length == 0)
				return Empty;

			string tmp = InternalAllocateStr (length);
			fixed (char* dest = tmp, src = this) {
				CharCopy (dest, src + startIndex, length);
			}
			return tmp;
		}

        IEnumerator IEnumerable.GetEnumerator()
        {
	return new CharEnumerator (this);
        }

        int IComparable.CompareTo(object value)
        {
       if (value == null)
				return 1;

			if (!(value is String))
				throw new ArgumentException ();

			return String.Compare (this, (String) value);
        }

        [SecuritySafeCritical]
        public char[] ToCharArray()
        {
            return null;
        }

        [SecuritySafeCritical]
        public char[] ToCharArray(int startIndex, int length)
        {
       	if (startIndex < 0)
				throw new ArgumentOutOfRangeException ("startIndex", "< 0"); 
			if (length < 0)
				throw new ArgumentOutOfRangeException ("length", "< 0"); 
			if (startIndex > this.length - length)
				throw new ArgumentOutOfRangeException ("startIndex", "Must be greater than the length of the string.");

			char[] tmp = new char [length];
			fixed (char* dest = tmp, src = this)
				CharCopy (dest, src + startIndex, length);
			return tmp;
        }

        public string ToLower()
        {
   return ToLower (CultureInfo.CurrentCulture);
        }

        String ToLower (CultureInfo culture)
		{
			if (culture == null)
				throw new ArgumentNullException ("culture");

			if (culture.LCID == 0x007F) // Invariant
				return ToLowerInvariant ();

			return culture.TextInfo.ToLower (this);
		}

        public unsafe string ToLowerInvariant()
        {
        	if (length == 0)
				return Empty;

			string tmp = InternalAllocateStr (length);
			fixed (char* source = &start_char, dest = tmp) {

				char* destPtr = (char*)dest;
				char* sourcePtr = (char*)source;

				for (int n = 0; n < length; n++) {
					*destPtr = Char.ToLowerInvariant (*sourcePtr);
					sourcePtr++;
					destPtr++;
				}
			}
			return tmp;
        }

        public override string ToString()
        {
            return this;
        }

        public string ToUpper()
        {
        		return ToUpper (CultureInfo.CurrentCulture);
        }

        String ToUpper (CultureInfo culture)
		{
			if (culture == null)
				throw new ArgumentNullException ("culture");

			if (culture.LCID == 0x007F) // Invariant
				return ToUpperInvariant ();

			return culture.TextInfo.ToUpper (this);
		}

        public unsafe string ToUpperInvariant()
        {
          if (length == 0)
				return Empty;

			string tmp = InternalAllocateStr (length);
			fixed (char* source = &start_char, dest = tmp) {

				char* destPtr = (char*)dest;
				char* sourcePtr = (char*)source;

				for (int n = 0; n < length; n++) {
					*destPtr = Char.ToUpperInvariant (*sourcePtr);
					sourcePtr++;
					destPtr++;
				}
			}
			return tmp;
        }

        public string Trim()
        {
        if (length == 0) 
				return Empty;
			int start = FindNotWhiteSpace (0, length, 1);

			if (start == length)
				return Empty;

			int end = FindNotWhiteSpace (length - 1, start, -1);

			int newLength = end - start + 1;
			if (newLength == length)
				return this;

			return SubstringUnchecked (start, newLength);
        }

        public string Trim(params char[] trimChars)
        {
       	if (trimChars == null || trimChars.Length == 0)
				return Trim ();

			if (length == 0) 
				return Empty;
			int start = FindNotInTable (0, length, 1, trimChars);

			if (start == length)
				return Empty;

			int end = FindNotInTable (length - 1, start, -1, trimChars);

			int newLength = end - start + 1;
			if (newLength == length)
				return this;

			return SubstringUnchecked (start, newLength);
        }

        public string TrimEnd(params char[] trimChars)
        {
           	if (length == 0) 
				return Empty;
			int end;
			if (trimChars == null || trimChars.Length == 0)
				end = FindNotWhiteSpace (length - 1, -1, -1);
			else
				end = FindNotInTable (length - 1, -1, -1, trimChars);

			end++;
			if (end == length)
				return this;

			return SubstringUnchecked (0, end);
        }

        public string TrimStart(params char[] trimChars)
        {
         	if (length == 0) 
				return Empty;
			int start;
			if (trimChars == null || trimChars.Length == 0)
				start = FindNotWhiteSpace (0, length, 1);
			else
				start = FindNotInTable (0, length, 1, trimChars);

			if (start == 0)
				return this;

			return SubstringUnchecked (start, length - start);
        }

        //		[IndexerName ("Chars")]
        public char this[int index]
        {
            [SecuritySafeCritical]
            get
            {
               if (index < 0 || index >= length)
					throw new IndexOutOfRangeException ();
				fixed (char* c = &start_char)
					return c[index];
            }
        }

        public int Length
        {
            [SecuritySafeCritical]
            get
            {

				return length;

            }
        }
    } //string
}

