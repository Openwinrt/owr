
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace System
{


    [StructLayout(LayoutKind.Sequential)]
    public struct Int16 : IComparable, IComparable<short>, IEquatable<short>, IFormattable
    {
        public const short MaxValue = 32767;
        public const short MinValue = -32768;

        internal short m_value;

        public int CompareTo(short value)
        {
            return m_value - value;
        }

        int IComparable.CompareTo(object value)
        {
            if (value is System.Int16)
                CompareTo((short)value);

            if (value == null)
                return 1;

            throw new ArgumentException(Locale.GetText("Value is not a System.Int16"));
        }

        public bool Equals(short obj)
        {
            return obj == m_value;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is System.Int16))
                return false;

            return ((short)obj) == m_value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
///CHECK   original just returned the value ...
///eg an array of incrementing numbers will not have a random seed. ( Prob ok for boxed collections) 
        public override int GetHashCode()
        {

               //return (int)~this  | (int) this; 
            return 257 * (m_value + 7);
              //  2654435761 * m_value;
        }

        public static short Parse(string s)
        {
            Exception exc;
            short res;

            if (!Parse(s, false, out res, out exc))
                throw exc;

            return res;
        }

        public static short Parse(string s, NumberStyles style)
        {
            return Parse(s, style, null);
        }

        public static short Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            int tmpResult = Int32.Parse(s, style, provider);
            if ((style & NumberStyles.AllowHexSpecifier) != 0)
            {
                if (tmpResult >= 0 && tmpResult <= ushort.MaxValue)
                    return (short)tmpResult;
            }
            else if (tmpResult <= MaxValue && tmpResult >= MinValue)
            {
                return (short)tmpResult;
            }

            throw new OverflowException("Value too large or too small.");
        }

        public static short Parse(string s, IFormatProvider provider)
        {
            return Parse(s, NumberStyles.Integer, provider);
        }

        internal static bool Parse(string s, bool tryParse, out short result, out Exception exc)
        {
            short val = 0;
            int len;
            int i, sign = 1;
            bool digits_seen = false;

            result = 0;
            exc = null;

            if (s == null)
            {
                if (!tryParse)
                    exc = new ArgumentNullException("s");
                return false;
            }

            len = s.Length;

            char c;
            for (i = 0; i < len; i++)
            {
                c = s[i];
                if (!Char.IsWhiteSpace(c))
                    break;
            }

            if (i == len)
            {
                if (!tryParse)
                    exc = Int32.GetFormatException();
                return false;
            }

            c = s[i];
            if (c == '+')
                i++;
            else if (c == '-')
            {
                sign = -1;
                i++;
            }

            for (; i < len; i++)
            {
                c = s[i];
                if (c >= '0' && c <= '9')
                {
                    byte d = (byte)(c - '0');

                    if (val > (MaxValue / 10))
                        goto overflow;

                    if (val == (MaxValue / 10))
                    {
                        if ((d > (MaxValue % 10)) && (sign == 1 || (d > ((MaxValue % 10) + 1))))
                            goto overflow;
                        if (sign == -1)
                            val = (short)((val * sign * 10) - d);
                        else
                            val = (short)((val * 10) + d);

                        if (Int32.ProcessTrailingWhitespace(tryParse, s, i + 1, ref exc))
                        {
                            result = val;
                            return true;
                        }
                        goto overflow;
                    }
                    else
                        val = (short)(val * 10 + d);


                    digits_seen = true;
                }
                else if (!Int32.ProcessTrailingWhitespace(tryParse, s, i, ref exc))
                    return false;

            }
            if (!digits_seen)
            {
                if (!tryParse)
                    exc = Int32.GetFormatException();
                return false;
            }

            if (sign == -1)
                result = (short)(val * sign);
            else
                result = val;

            return true;

        overflow:
            if (!tryParse)
                exc = new OverflowException(Locale.GetText("Value is too large"));
            return false;
        }


     

       //TODO [SecuritySafeCritical]
        public override string ToString()
        {
            return NumberFormatter.NumberToString(m_value, null);
        }

        //TODO [SecuritySafeCritical]
        public string ToString(IFormatProvider provider)
        {
            return NumberFormatter.NumberToString(m_value, provider);
        }

        public string ToString(string format)
        {
            return ToString(format, null);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            return NumberFormatter.NumberToString(format, m_value, provider);
        }

        public static bool TryParse(string s, out short result)
        {
            Exception exc;
            if (!Parse(s, true, out result, out exc))
            {
                result = 0;
                return false;
            }

            return true;
        }

        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result)
        {
            int tmpResult;
            result = 0;

            if (!Int32.TryParse(s, style, provider, out tmpResult))
                return false;

            if (tmpResult > Int16.MaxValue || tmpResult < Int16.MinValue)
                return false;

            result = (short)tmpResult;
            return true;
        }
    }
}

