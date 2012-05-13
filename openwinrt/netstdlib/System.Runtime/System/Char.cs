namespace System
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct Char : IComparable, IComparable<char>, IEquatable<char>
    {
        public const char MaxValue = (char)0xffff;
        public const char MinValue = (char)0;


        		static Char ()
		{
			unsafe {
				GetDataTablePointers (CategoryDataVersion,
					out category_data, out category_astral_index, out numeric_data,
					out numeric_data_values, out to_lower_data_low, out to_lower_data_high,
					out to_upper_data_low, out to_upper_data_high);
				category_check_pair = category_astral_index != null
					? (byte)UnicodeCategory.Surrogate
					: (byte)0xff;
			}
		}

		private readonly unsafe static byte *category_data;
		private readonly unsafe static ushort *category_astral_index;
		private readonly unsafe static byte *numeric_data;
		private readonly unsafe static double *numeric_data_values;
		private readonly unsafe static ushort *to_lower_data_low;
		private readonly unsafe static ushort *to_lower_data_high;
		private readonly unsafe static ushort *to_upper_data_low;
		private readonly unsafe static ushort *to_upper_data_high;

		// UnicodeCategory.Surrogate if astral plane
		// categories are available, 0xff otherwise.
		private readonly static byte category_check_pair;

		private const int CategoryDataVersion = 4;

        [MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        private unsafe static extern void GetDataTablePointers(int category_data_version,
            out byte* category_data, out ushort* category_astral_index, out byte* numeric_data,
            out double* numeric_data_values, out ushort* to_lower_data_low, out ushort* to_lower_data_high,
            out ushort* to_upper_data_low, out ushort* to_upper_data_high);



        public int CompareTo(char value)
        {
            return m_value - value;
        }

        int IComparable.CompareTo(object value)
        {
            if (value == null)
                return 1;

            if (!(value is System.Char))
                throw new ArgumentException(Locale.GetText("Value is not a System.Char"));

            return CompareTo((char)value);
            //char xv = (char)value;
            //if (m_value == xv)
            //    return 0;

            //if (m_value > xv)
            //    return 1;
            //else
            //    return -1;
        }



        public bool Equals(char obj)
        {
            return m_value == obj;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Char))
                return false;

            return ((char)obj) == m_value;
        }

        public override int GetHashCode()
        {
            return 42589 * (m_value + 7);
        }

        public static string ConvertFromUtf32(int utf32)
        {
            if (utf32 < 0 || utf32 > 0x10FFFF)
                throw new ArgumentOutOfRangeException("utf32", "The argument must be from 0 to 0x10FFFF.");
            if (0xD800 <= utf32 && utf32 <= 0xDFFF)
                throw new ArgumentOutOfRangeException("utf32", "The argument must not be in surrogate pair range.");
            if (utf32 < 0x10000)
                return new string((char)utf32, 1);
            utf32 -= 0x10000;
            return new string(
                new char[] {(char) ((utf32 >> 10) + 0xD800),
				(char) (utf32 % 0x0400 + 0xDC00)});
        }

        public static int ConvertToUtf32(char highSurrogate, char lowSurrogate)
        {
            if (highSurrogate < 0xD800 || 0xDBFF < highSurrogate)
                throw new ArgumentOutOfRangeException("highSurrogate");
            if (lowSurrogate < 0xDC00 || 0xDFFF < lowSurrogate)
                throw new ArgumentOutOfRangeException("lowSurrogate");

            return 0x10000 + ((highSurrogate - 0xD800) << 10) + (lowSurrogate - 0xDC00);

        }

        public static int ConvertToUtf32(string s, int index)
        {
            CheckParameter(s, index);

            if (!Char.IsSurrogate(s[index]))
                return s[index];
            if (!Char.IsHighSurrogate(s[index])
                || index == s.Length - 1
                || !Char.IsLowSurrogate(s[index + 1]))
                throw new ArgumentException(String.Format("The string contains invalid surrogate pair character at {0}", index));
            return ConvertToUtf32(s[index], s[index + 1]);

        }

        public static double GetNumericValue(char c)
        {
            if (c > (char)0x3289)
            {
                if (c >= (char)0xFF10 && c <= (char)0xFF19)
                    return (c - 0xFF10); // Numbers 0-9

                // Default not set data
                return -1;
            }
            else
            {
                unsafe
                {
                    return numeric_data_values[numeric_data[c]];
                }
            }
        }

        public static double GetNumericValue(string s, int index)
        {
            CheckParameter(s, index);
            return GetNumericValue(s[index]);
        }

        public static bool IsControl(char c)
        {
            unsafe
            {
                return (category_data[c] == (byte)UnicodeCategory.Control);
            }
        }

        public static bool IsControl(string s, int index)
        {
            CheckParameter(s, index);
            return IsControl(s[index]);
        }

        public static bool IsDigit(char c)
        {
            unsafe
            {
                return (category_data[c] == (byte)UnicodeCategory.DecimalDigitNumber);
            }
        }

        public static bool IsDigit(string s, int index)
        {
            CheckParameter(s, index);
            return IsDigit(s[index]);
        }

        public static bool IsHighSurrogate(char c)
        {
            return c >= '\uD800' && c <= '\uDBFF';
        }

        public static bool IsHighSurrogate(string s, int index)
        {
            CheckParameter(s, index);
            return IsHighSurrogate(s[index]);
        }

        public static bool IsLetter(char c)
        {
            unsafe
            {
                return category_data[c] <= ((byte)UnicodeCategory.OtherLetter);
            }
        }

        public static bool IsLetter(string s, int index)
        {
            CheckParameter(s, index);
            return IsLetter(s[index]);
        }

        public static bool IsLetterOrDigit(char c)
        {
            unsafe
            {
                int category = category_data[c];
                return (category <= ((int)UnicodeCategory.OtherLetter) ||
                        category == ((int)UnicodeCategory.DecimalDigitNumber));
            }
        }

        public static bool IsLetterOrDigit(string s, int index)
        {
            CheckParameter(s, index);
            return IsLetterOrDigit(s[index]);
        }

        public static bool IsLower(char c)
        {
            unsafe
            {
                return (category_data[c] == (byte)UnicodeCategory.LowercaseLetter);
            }
        }

        public static bool IsLower(string s, int index)
        {
            CheckParameter(s, index);
            return IsLower(s[index]);
        }

        public static bool IsLowSurrogate(char c)
        {
            return c >= '\uDC00' && c <= '\uDFFF';
        }

        public static bool IsLowSurrogate(string s, int index)
        {
            CheckParameter(s, index);
            return IsLowSurrogate(s[index]);
        }

        public static bool IsNumber(char c)
        {
            unsafe
            {
                int category = category_data[c];
                return (category >= ((int)UnicodeCategory.DecimalDigitNumber) &&
                        category <= ((int)UnicodeCategory.OtherNumber));
            }
        }

        public static bool IsNumber(string s, int index)
        {
            CheckParameter(s, index);
            return IsNumber(s[index]);
        }

        public static bool IsPunctuation(char c)
        {
            unsafe
            {
                int category = category_data[c];
                return (category >= ((int)UnicodeCategory.ConnectorPunctuation) &&
                        category <= ((int)UnicodeCategory.OtherPunctuation));
            }
        }

        public static bool IsPunctuation(string s, int index)
        {
            CheckParameter(s, index);
            return IsPunctuation(s[index]);
        }

        public static bool IsSeparator(char c)
        {
            unsafe
            {
                int category = category_data[c];
                return (category >= ((int)UnicodeCategory.SpaceSeparator) &&
                        category <= ((int)UnicodeCategory.ParagraphSeparator));
            }
        }

        public static bool IsSeparator(string s, int index)
        {
            CheckParameter(s, index);
            return IsSeparator(s[index]);
        }

        public static bool IsSurrogate(char c)
        {
            unsafe
            {
                return (category_data[c] == (byte)UnicodeCategory.Surrogate);
            }
        }

        public static bool IsSurrogate(string s, int index)
        {
            CheckParameter(s, index);
            return IsSurrogate(s[index]);
        }

        public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate)
        {
            return '\uD800' <= highSurrogate && highSurrogate <= '\uDBFF'
            && '\uDC00' <= lowSurrogate && lowSurrogate <= '\uDFFF';

        }

        public static bool IsSurrogatePair(string s, int index)
        {
            CheckParameter(s, index);
            return index + 1 < s.Length && IsSurrogatePair(s[index], s[index + 1]);

        }

        public static bool IsSymbol(char c)
        {
            unsafe
            {
                int category = category_data[c];
                return (category >= ((int)UnicodeCategory.MathSymbol) &&
                        category <= ((int)UnicodeCategory.OtherSymbol));
            }
        }

        public static bool IsSymbol(string s, int index)
        {
            CheckParameter(s, index);
            return IsSymbol(s[index]);
        }

        public static bool IsUpper(char c)
        {
            return 0;
        }

        public static bool IsUpper(string s, int index)
        {
            unsafe
            {
                return (category_data[c] == (byte)UnicodeCategory.UppercaseLetter);
            }
        }

        public static bool IsWhiteSpace(char c)
        {
            if (c < 0x1680)
                return c == 0x20 || c >= 0x09 && c <= 0x0d || c == 0x85 || c == 0xA0;

            unsafe
            {
                int category = category_data[c];
                return category > (int)UnicodeCategory.OtherNumber && category <= (int)UnicodeCategory.ParagraphSeparator;
            }
        }

        public static bool IsWhiteSpace(string s, int index)
        {
            CheckParameter(s, index);
            return IsWhiteSpace(s[index]);
        }



        public static char ToLower(char c)
        {
            // CurrentCulture is never null or Invariant
            return CultureInfo.CurrentCulture.TextInfo.ToLower(c);
        }

        public static char ToLowerInvariant(char c)
        {
            unsafe
            {
                if (c <= ((char)0x24cf))
                    return (char)to_lower_data_low[c];
                if (c >= ((char)0xff21))
                    return (char)to_lower_data_high[c - 0xff21];
            }
            return c;
        }



        public static char ToUpper(char c)
        {
            // CurrentCulture is never null or Invariant
            return CultureInfo.CurrentCulture.TextInfo.ToUpper(c);
        }

        public static char ToUpperInvariant(char c)
        {
            unsafe
            {
                if (c <= ((char)0x24e9))
                    return (char)to_upper_data_low[c];
                if (c >= ((char)0xff21))
                    return (char)to_upper_data_high[c - 0xff21];
            }
            return c;
        }

        private static void CheckParameter(string s, int index)
        {
            if (s == null)
                throw new ArgumentNullException("s");

            if (index < 0 || index >= s.Length)
                throw new ArgumentOutOfRangeException(
                    Locale.GetText("The value of index is less than zero, or greater than or equal to the length of s."));
        }

        public static unsafe bool TryParse(string s, out char result)
        {
            *((short*) result) = 0;
            return 0;
        }

        public override string ToString()
        {
            return new String(m_value, 1);
        }

        public static string ToString(char c)
        {
            return new String(c, 1);
        }
    }
}

