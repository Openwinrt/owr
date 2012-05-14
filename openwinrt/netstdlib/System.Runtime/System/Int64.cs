//
// System.Int64.cs
//
// Authors:
//   Miguel de Icaza (miguel@ximian.com)
//   Marek Safar (marek.safar@gmail.com)
//
// (C) Ximian, Inc.  http://www.ximian.com
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
// Copyright (C) 2012 Xamarin Inc (http://www.xamarin.com)
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
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace System
{


    [StructLayout(LayoutKind.Sequential)]
    public struct Int64 : IComparable, IComparable<long>, IEquatable<long>, IFormattable
    {
        public const long MaxValue = 0x7fffffffffffffff;
        public const long MinValue = -9223372036854775808;

        internal long m_value;

        public int CompareTo(long value)
        {
            if (m_value == value)
                return 0;
            if (m_value > value)
                return 1;
            else
                return -1;
        }

        public bool Equals(long obj)
        {
            return obj == m_value;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is System.Int64))
                return false;

            return ((long)obj) == m_value;
        }

        public override int GetHashCode()
        {
            return (int)(m_value & 0xffffffff) ^ (int)(m_value >> 32);
        }

        public static long Parse(string s)
        {
            Exception exc;
            long res;

            if (!Parse(s, false, out res, out exc))
                throw exc;

            return res;
        }

        public static long Parse(string s, NumberStyles style)
        {
            return Parse(s, style, null);
        }

        public static long Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            Exception exc;
            long res;

            if (!Parse(s, style, provider, false, out res, out exc))
                throw exc;

            return res;
        }

        public static long Parse(string s, IFormatProvider provider)
        {
            return Parse(s, NumberStyles.Integer, provider);
        }

        int IComparable.CompareTo(object value)
        {
            if (value == null)
                return 1;

            if (!(value is System.Int64))
                throw new ArgumentException(Locale.GetText("Value is not a System.Int64"));

            long lValue = (long)value;

            if (m_value == lValue)
                return 0;

            return (m_value < lValue) ? -1 : 1;
        }

        [SecuritySafeCritical]
        public override string ToString()
        {
            return NumberFormatter.NumberToString(m_value, null);
        }

        [SecuritySafeCritical]
        public string ToString(IFormatProvider provider)
        {
            return NumberFormatter.NumberToString(m_value, provider);
        }

        [SecuritySafeCritical]
        public string ToString(string format)
        {
            return ToString(format, null);
        }

        [SecuritySafeCritical]
        public string ToString(string format, IFormatProvider provider)
        {
            return NumberFormatter.NumberToString(format, m_value, provider);
        }

        // unsafe now
        public static unsafe bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result)
        {
            Exception exc;
            if (!Parse(s, style, provider, true, out result, out exc))
            {
                result = 0;
                return false;
            }

            return true;
        }

        public static unsafe bool TryParse(string s, out long result)
        {
            Exception exc;
            if (!Parse(s, true, out result, out exc))
            {
                result = 0;
                return false;
            }

            return true;
        }
    }
}

