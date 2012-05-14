namespace System
{
    using System.Globalization;
    using System.Runtime.InteropServices;
    using System.Security;

    [StructLayout(LayoutKind.Sequential)]
    public struct Single : IComparable, IComparable<float>, IEquatable<float>, IFormattable
    {
        public const float Epsilon = 1.4e-45f;
        public const float MaxValue = 3.40282346638528859e38f;
        public const float MinValue = -3.40282346638528859e38f;
        public const float NaN = 0.0f / 0.0f;
        public const float PositiveInfinity = 1.0f / 0.0f;
        public const float NegativeInfinity = -1.0f / 0.0f;

        public int CompareTo(float value)
        {

            if (IsPositiveInfinity(m_value) && IsPositiveInfinity(value))
                return 0;

            if (IsNegativeInfinity(m_value) && IsNegativeInfinity(value))
                return 0;

            if (IsNaN(value))
                if (IsNaN(m_value))
                    return 0;
                else
                    return 1;

            if (IsNaN(m_value))
                if (IsNaN(value))
                    return 0;
                else
                    return -1;

            if (this.m_value == value)
                return 0;
            else if (this.m_value > value)
                return 1;
            else
                return -1;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is System.Single))
                return false;

            float value = (float)obj;

            if (IsNaN(value))
                return IsNaN(m_value);

            return (value == m_value);
        }

        public bool Equals(float obj)
        {
            if (IsNaN(obj))
                return IsNaN(m_value);

            return obj == m_value;
        }

        [SecuritySafeCritical]
        public unsafe 
            override int GetHashCode()
        {
            float f = m_value;
            return *((int*)&f);
        }

        [SecuritySafeCritical]
        public static bool IsInfinity(float f)
        {
            return (f == PositiveInfinity || f == NegativeInfinity);
        }


        //dont understand this equal must be more expensive
        [SecuritySafeCritical]
        public static bool IsNaN(float f)
        {
#pragma warning disable 1718
            return (f != f);
#pragma warning restore
        }

        [SecuritySafeCritical]
        public static bool IsNegativeInfinity(float f)
        {
            return (f < 0.0f && (f == NegativeInfinity || f == PositiveInfinity));
        }

        [SecuritySafeCritical]
        public static bool IsPositiveInfinity(float f)
        {
            return (f > 0.0f && (f == NegativeInfinity || f == PositiveInfinity));
        }

        public static bool operator ==(float left, float right)
        {
            return left == right;
        }

        public static bool operator >(float left, float right)
        {
            return left > right;
        }

        public static bool operator >=(float left, float right)
        {
            return left >= right;
        }

        public static bool operator !=(float left, float right)
        {
            return left != right;
        }

        public static bool operator <(float left, float right)
        {
            return left < right;
        }

        public static bool operator <=(float left, float right)
        {
            return left <= right;
        }

        public static float Parse(string s)
        {
            double parsed_value = Double.Parse(
                      s, (NumberStyles.Float | NumberStyles.AllowThousands), null);
            if (parsed_value - (double)float.MaxValue > MaxValueEpsilon && (!double.IsPositiveInfinity(parsed_value)))
                throw new OverflowException();

            return (float)parsed_value;
        }

        public static float Parse(string s, NumberStyles style)
        {
            double parsed_value = Double.Parse(s, style, null);
            if (parsed_value - (double)float.MaxValue > MaxValueEpsilon && (!double.IsPositiveInfinity(parsed_value)))
                throw new OverflowException();

            return (float)parsed_value;
        }

        public static float Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            double parsed_value = Double.Parse(s, style, provider);
            if (parsed_value - (double)float.MaxValue > MaxValueEpsilon && (!double.IsPositiveInfinity(parsed_value)))
                throw new OverflowException();

            return (float)parsed_value;
        }

        public static float Parse(string s, IFormatProvider provider)
        {
            double parsed_value = Double.Parse(
                        s, (NumberStyles.Float | NumberStyles.AllowThousands), provider);
            if (parsed_value - (double)float.MaxValue > MaxValueEpsilon && (!double.IsPositiveInfinity(parsed_value)))
                throw new OverflowException();

            return (float)parsed_value;
        }

        int IComparable.CompareTo(object value)
        {
            if (value == null)
                return 1;

            if (!(value is System.Single))
                throw new ArgumentException(Locale.GetText("Value is not a System.Single."));

            float fv = (float)value;

            if (IsPositiveInfinity(m_value) && IsPositiveInfinity(fv))
                return 0;

            if (IsNegativeInfinity(m_value) && IsNegativeInfinity(fv))
                return 0;

            if (IsNaN(fv))
                if (IsNaN(m_value))
                    return 0;
                else
                    return 1;

            if (IsNaN(m_value))
                if (IsNaN(fv))
                    return 0;
                else
                    return -1;

            if (this.m_value == fv)
                return 0;
            else if (this.m_value > fv)
                return 1;
            else
                return -1;
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

        public static unsafe bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result)
        {
            double parsed_value;
            Exception exc;
            if (!Double.Parse(s, style, provider, true, out parsed_value, out exc))
            {
                result = 0;
                return false;
            }
            else if (parsed_value - (double)float.MaxValue > MaxValueEpsilon && (!double.IsPositiveInfinity(parsed_value)))
            {
                result = 0;
                return false;
            }
            result = (float)parsed_value;
            return true;
        }

        public static unsafe bool TryParse(string s, out float result)
        {
            return TryParse(s, NumberStyles.Any, null, out result);
        }
    }
}

