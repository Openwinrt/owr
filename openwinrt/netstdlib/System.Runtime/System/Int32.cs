   
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace System
{


    [StructLayout(LayoutKind.Sequential)]
    public struct Int32 : IComparable, IComparable<int>, IEquatable<int>, IFormattable
    {
       public const int MaxValue = 0x7fffffff;
        public const int MinValue = -2147483648;

        internal int m_value;

        public int CompareTo(int value)
        {
            return m_value - value;
        }

        int IComparable.CompareTo(object value)
        {
            if (value is System.Int32)
                CompareTo((int)value);

            if (value == null)
                return 1;

            throw new ArgumentException(Locale.GetText("Value is not a System.Int32"));
        }

        public bool Equals(int obj)
        {
            return obj == m_value;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is System.Int32))
                return false;

            return ((int)obj) == m_value;
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

            return 2654435761 * (m_value + 3);
        }

        public static int Parse(string s)
        {
            Exception exc;
            int res;

            if (!Parse(s, false, out res, out exc))
                throw exc;

            return res;
        }

        public static int Parse(string s, NumberStyles style)
        {
            return Parse(s, style, null);
        }

        public static int Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            Exception exc;
            int res;

            if (!Parse(s, style, provider, false, out res, out exc))
                throw exc;

            return res;
        }

        public static int Parse(string s, IFormatProvider provider)
        {
            return Parse(s, NumberStyles.Integer, provider);
        }

        internal static bool Parse(string s, NumberStyles style, IFormatProvider fp, bool tryParse, out int result, out Exception exc)
        {
            result = 0;
            exc = null;

            if (s == null)
            {
                if (!tryParse)
                    exc = new ArgumentNullException("s");
                return false;
            }

            if (s.Length == 0)
            {
                if (!tryParse)
                    exc = GetFormatException();
                return false;
            }

            NumberFormatInfo nfi = null;
            if (fp != null)
            {
                Type typeNFI = typeof(System.Globalization.NumberFormatInfo);
                nfi = (NumberFormatInfo)fp.GetFormat(typeNFI);
            }
            if (nfi == null)
                nfi = Thread.CurrentThread.CurrentCulture.NumberFormat;

            if (!CheckStyle(style, tryParse, ref exc))
                return false;

            bool AllowCurrencySymbol = (style & NumberStyles.AllowCurrencySymbol) != 0;
            bool AllowHexSpecifier = (style & NumberStyles.AllowHexSpecifier) != 0;
            bool AllowThousands = (style & NumberStyles.AllowThousands) != 0;
            bool AllowDecimalPoint = (style & NumberStyles.AllowDecimalPoint) != 0;
            bool AllowParentheses = (style & NumberStyles.AllowParentheses) != 0;
            bool AllowTrailingSign = (style & NumberStyles.AllowTrailingSign) != 0;
            bool AllowLeadingSign = (style & NumberStyles.AllowLeadingSign) != 0;
            bool AllowTrailingWhite = (style & NumberStyles.AllowTrailingWhite) != 0;
            bool AllowLeadingWhite = (style & NumberStyles.AllowLeadingWhite) != 0;
            bool AllowExponent = (style & NumberStyles.AllowExponent) != 0;

            int pos = 0;

            if (AllowLeadingWhite && !JumpOverWhite(ref pos, s, true, tryParse, ref exc))
                return false;

            bool foundOpenParentheses = false;
            bool negative = false;
            bool foundSign = false;
            bool foundCurrency = false;

            // Pre-number stuff
            if (AllowParentheses && s[pos] == '(')
            {
                foundOpenParentheses = true;
                foundSign = true;
                negative = true; // MS always make the number negative when there parentheses
                // even when NumberFormatInfo.NumberNegativePattern != 0!!!
                pos++;
                if (AllowLeadingWhite && !JumpOverWhite(ref pos, s, true, tryParse, ref exc))
                    return false;

                if (s.Substring(pos, nfi.NegativeSign.Length) == nfi.NegativeSign)
                {
                    if (!tryParse)
                        exc = GetFormatException();
                    return false;
                }

                if (s.Substring(pos, nfi.PositiveSign.Length) == nfi.PositiveSign)
                {
                    if (!tryParse)
                        exc = GetFormatException();
                    return false;
                }
            }

            if (AllowLeadingSign && !foundSign)
            {
                // Sign + Currency
                FindSign(ref pos, s, nfi, ref foundSign, ref negative);
                if (foundSign)
                {
                    if (AllowLeadingWhite && !JumpOverWhite(ref pos, s, true, tryParse, ref exc))
                        return false;
                    if (AllowCurrencySymbol)
                    {
                        FindCurrency(ref pos, s, nfi,
                                  ref foundCurrency);
                        if (foundCurrency && AllowLeadingWhite &&
                                !JumpOverWhite(ref pos, s, true, tryParse, ref exc))
                            return false;
                    }
                }
            }

            if (AllowCurrencySymbol && !foundCurrency)
            {
                // Currency + sign
                FindCurrency(ref pos, s, nfi, ref foundCurrency);
                if (foundCurrency)
                {
                    if (AllowLeadingWhite && !JumpOverWhite(ref pos, s, true, tryParse, ref exc))
                        return false;
                    if (foundCurrency)
                    {
                        if (!foundSign && AllowLeadingSign)
                        {
                            FindSign(ref pos, s, nfi, ref foundSign,
                                  ref negative);
                            if (foundSign && AllowLeadingWhite &&
                                    !JumpOverWhite(ref pos, s, true, tryParse, ref exc))
                                return false;
                        }
                    }
                }
            }

            int number = 0;
            int nDigits = 0;
            bool decimalPointFound = false;
            int digitValue;
            char hexDigit;
            int exponent = 0;

            // Number stuff
            do
            {

                if (!ValidDigit(s[pos], AllowHexSpecifier))
                {
                    if (AllowThousands &&
                        (FindOther(ref pos, s, nfi.NumberGroupSeparator)
                        || FindOther(ref pos, s, nfi.CurrencyGroupSeparator)))
                        continue;
                    else
                        if (!decimalPointFound && AllowDecimalPoint &&
                            (FindOther(ref pos, s, nfi.NumberDecimalSeparator)
                            || FindOther(ref pos, s, nfi.CurrencyDecimalSeparator)))
                        {
                            decimalPointFound = true;
                            continue;
                        }

                    break;
                }
                if (AllowHexSpecifier)
                {
                    nDigits++;
                    hexDigit = s[pos++];
                    if (Char.IsDigit(hexDigit))
                        digitValue = (int)(hexDigit - '0');
                    else if (Char.IsLower(hexDigit))
                        digitValue = (int)(hexDigit - 'a' + 10);
                    else
                        digitValue = (int)(hexDigit - 'A' + 10);

                    uint unumber = (uint)number;
                    if (tryParse)
                    {
                        if ((unumber & 0xf0000000) != 0)
                            return false;

                        number = (int)(unumber * 16u + (uint)digitValue);
                    }
                    else
                    {
                        number = (int)checked(unumber * 16u + (uint)digitValue);
                    }
                }
                else if (decimalPointFound)
                {
                    nDigits++;
                    // Allows decimal point as long as it's only 
                    // followed by zeroes.
                    if (s[pos++] != '0')
                    {
                        if (!tryParse)
                            exc = new OverflowException("Value too large or too " +
                                    "small.");
                        return false;
                    }
                }
                else
                {
                    nDigits++;

                    try
                    {
                        // Calculations done as negative
                        // (abs (MinValue) > abs (MaxValue))
                        number = checked(
                            number * 10 -
                            (int)(s[pos++] - '0')
                            );
                    }
                    catch (OverflowException)
                    {
                        if (!tryParse)
                            exc = new OverflowException("Value too large or too " +
                                    "small.");
                        return false;
                    }
                }
            } while (pos < s.Length);

            // Post number stuff
            if (nDigits == 0)
            {
                if (!tryParse)
                    exc = GetFormatException();
                return false;
            }

            if (AllowExponent)
                if (FindExponent(ref pos, s, ref exponent, tryParse, ref exc) && exc != null)
                    return false;

            if (AllowTrailingSign && !foundSign)
            {
                // Sign + Currency
                FindSign(ref pos, s, nfi, ref foundSign, ref negative);
                if (foundSign && pos < s.Length)
                {
                    if (AllowTrailingWhite && !JumpOverWhite(ref pos, s, true, tryParse, ref exc))
                        return false;
                }
            }

            if (AllowCurrencySymbol && !foundCurrency)
            {
                if (AllowTrailingWhite && pos < s.Length && !JumpOverWhite(ref pos, s, false, tryParse, ref exc))
                    return false;

                // Currency + sign
                FindCurrency(ref pos, s, nfi, ref foundCurrency);
                if (foundCurrency && pos < s.Length)
                {
                    if (AllowTrailingWhite && !JumpOverWhite(ref pos, s, true, tryParse, ref exc))
                        return false;
                    if (!foundSign && AllowTrailingSign)
                        FindSign(ref pos, s, nfi, ref foundSign,
                              ref negative);
                }
            }

            if (AllowTrailingWhite && pos < s.Length && !JumpOverWhite(ref pos, s, false, tryParse, ref exc))
                return false;

            if (foundOpenParentheses)
            {
                if (pos >= s.Length || s[pos++] != ')')
                {
                    if (!tryParse)
                        exc = GetFormatException();
                    return false;
                }
                if (AllowTrailingWhite && pos < s.Length && !JumpOverWhite(ref pos, s, false, tryParse, ref exc))
                    return false;
            }

            if (pos < s.Length && s[pos] != '\u0000')
            {
                if (!tryParse)
                    exc = GetFormatException();
                return false;
            }

            if (!negative && !AllowHexSpecifier)
            {
                if (tryParse)
                {
                    long lval = -((long)number);

                    if (lval < MinValue || lval > MaxValue)
                        return false;
                    number = (int)lval;
                }
                else
                    number = checked(-number);
            }

            // result *= 10^exponent
            if (exponent > 0)
            {
                // Reduce the risk of throwing an overflow exc
                double res = checked(Math.Pow(10, exponent) * number);
                if (res < Int32.MinValue || res > Int32.MaxValue)
                {
                    if (!tryParse)
                        exc = new OverflowException("Value too large or too small.");
                    return false;
                }

                number = (int)res;
            }

            result = number;
            return true;
        }

        static bool FindOther(ref int pos,
                      string s,
                      string other)
        {
            if ((pos + other.Length) <= s.Length &&
                 s.Substring(pos, other.Length) == other)
            {
                pos += other.Length;
                return true;
            }

            return false;
        }

        static bool ValidDigit(char e, bool allowHex)
        {
            if (allowHex)
                return Char.IsDigit(e) || (e >= 'A' && e <= 'F') || (e >= 'a' && e <= 'f');

            return Char.IsDigit(e);
        }

        static Exception GetFormatException()
        {
            return new FormatException("Input string was not in the correct format");
        }

        static bool FindExponent(ref int pos, string s, ref int exponent, bool tryParse, ref Exception exc)
        {
            exponent = 0;

            if (pos >= s.Length || (s[pos] != 'e' && s[pos] != 'E'))
            {
                exc = null;
                return false;
            }

            var i = pos + 1;
            if (i == s.Length)
            {
                exc = tryParse ? null : GetFormatException();
                return true;
            }

            // negative exponent not valid for Int32
            if (s[i] == '-')
            {
                exc = tryParse ? null : new OverflowException("Value too large or too small.");
                return true;
            }

            if (s[i] == '+' && ++i == s.Length)
            {
                exc = tryParse ? null : GetFormatException();
                return true;
            }

            long exp = 0; // temp long value
            for (; i < s.Length; i++)
            {
                if (!Char.IsDigit(s[i]))
                {
                    exc = tryParse ? null : GetFormatException();
                    return true;
                }

                // Reduce the risk of throwing an overflow exc
                exp = checked(exp * 10 - (int)(s[i] - '0'));
                if (exp < Int32.MinValue || exp > Int32.MaxValue)
                {
                    exc = tryParse ? null : new OverflowException("Value too large or too small.");
                    return true;
                }
            }

            // exp value saved as negative
            exp = -exp;

            exc = null;
            exponent = (int)exp;
            pos = i;
            return true;
        }

        //TODO Move the helper class out!
        static bool CheckStyle(NumberStyles style, bool tryParse, ref Exception exc)
        {
            if ((style & NumberStyles.AllowHexSpecifier) != 0)
            {
                NumberStyles ne = style ^ NumberStyles.AllowHexSpecifier;
                if ((ne & NumberStyles.AllowLeadingWhite) != 0)
                    ne ^= NumberStyles.AllowLeadingWhite;
                if ((ne & NumberStyles.AllowTrailingWhite) != 0)
                    ne ^= NumberStyles.AllowTrailingWhite;
                if (ne != 0)
                {
                    if (!tryParse)
                        exc = new ArgumentException(
                            "With AllowHexSpecifier only " +
                            "AllowLeadingWhite and AllowTrailingWhite " +
                            "are permitted.");
                    return false;
                }
            }
            else if ((uint)style > (uint)NumberStyles.Any)
            {
                if (!tryParse)
                    exc = new ArgumentException("Not a valid number style");
                return false;
            }

            return true;
        }

        static bool ProcessTrailingWhitespace(bool tryParse, string s, int position, ref Exception exc)
        {
            int len = s.Length;

            for (int i = position; i < len; i++)
            {
                char c = s[i];

                if (c != 0 && !Char.IsWhiteSpace(c))
                {
                    if (!tryParse)
                        exc = GetFormatException();
                    return false;
                }
            }
            return true;
        }

        static bool JumpOverWhite(ref int pos, string s, bool reportError, bool tryParse, ref Exception exc)
        {
            while (pos < s.Length && Char.IsWhiteSpace(s[pos]))
                pos++;

            if (reportError && pos >= s.Length)
            {
                if (!tryParse)
                    exc = GetFormatException();
                return false;
            }

            return true;
        }

       static void FindSign(ref int pos, string s, NumberFormatInfo nfi,
                      ref bool foundSign, ref bool negative)
        {
            if ((pos + nfi.NegativeSign.Length) <= s.Length &&
                s.IndexOf(nfi.NegativeSign, pos, nfi.NegativeSign.Length) == pos)
            {
                negative = true;
                foundSign = true;
                pos += nfi.NegativeSign.Length;
            }
            else if ((pos + nfi.PositiveSign.Length) <= s.Length &&
              s.IndexOf(nfi.PositiveSign, pos, nfi.PositiveSign.Length) == pos)
            {
                negative = false;
                pos += nfi.PositiveSign.Length;
                foundSign = true;
            }
        }

        static void FindCurrency(ref int pos,
                         string s,
                         NumberFormatInfo nfi,
                         ref bool foundCurrency)
        {
            if ((pos + nfi.CurrencySymbol.Length) <= s.Length &&
                 s.Substring(pos, nfi.CurrencySymbol.Length) == nfi.CurrencySymbol)
            {
                foundCurrency = true;
                pos += nfi.CurrencySymbol.Length;
            }
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

        public static bool TryParse(string s, out int result)
        {
            Exception exc;
            if (!Parse(s, true, out result, out exc))
            {
                result = 0;
                return false;
            }

            return true;
        }

        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result)
        {
            int tmpResult;
            result = 0;

            if (!Int32.TryParse(s, style, provider, out tmpResult))
                return false;

            if (tmpResult > Int32.MaxValue || tmpResult < Int32.MinValue)
                return false;

            result = (int)tmpResult;
            return true;
        }
    }
}

