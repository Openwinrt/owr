//
// System.Byte.cs
//
// Author:
//   Miguel de Icaza (miguel@ximian.com)
//
// (C) Ximian, Inc.  http://www.ximian.com
//

//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
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

using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;


namespace System
{


    [StructLayoutAttribute(LayoutKind.Sequential)]
    public struct Byte : IComparable, IComparable<byte>, IEquatable<byte>, IFormattable
    {
        public const byte MaxValue = 255;
        public const byte MinValue = 0;

        internal byte m_value;

        public int CompareTo(byte value)
        {
            return m_value - value;
        }

        int IComparable.CompareTo(object value)
        {
            if (value is System.Byte)
                CompareTo((byte)value);

            if (value == null)
                return 1;

            throw new ArgumentException(Locale.GetText("Value is not a System.Byte"));
        }

        public bool Equals(byte obj)
        {
            return obj == m_value;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is System.Byte))
                return false;

            return ((byte)obj) == m_value;
        }

        public override int GetHashCode()
        {
            return 157 * (m_value + 3);
            //return 2654435761 * m_value; 
        }

        public static byte Parse(string s)
        {
            return Parse(s, NumberStyles.Integer, null);
        }

        public static byte Parse(string s, NumberStyles style)
        {
            return Parse(s, style, null);
        }

        public static byte Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            uint tmpResult = UInt32.Parse(s, style, provider);
            if (tmpResult > Byte.MaxValue)
                throw new OverflowException(Locale.GetText("Value too large."));

            return (byte)tmpResult;
        }

        public static byte Parse(string s, IFormatProvider provider)
        {
            return Parse(s, NumberStyles.Integer, provider);
        }


        public static unsafe bool TryParse(string s, out byte result)
        {
            return TryParse(s, NumberStyles.Integer, null, out result);

        }

        public static unsafe bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result)
        {
            uint tmpResult;
            result = 0;

            if (!UInt32.TryParse(s, style, provider, out tmpResult))
                return false;

            if (tmpResult > Byte.MaxValue)
                return false;

            result = (byte)tmpResult;
            return true;
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

    }
}

