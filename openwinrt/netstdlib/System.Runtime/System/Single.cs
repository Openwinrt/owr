namespace System
{
    using System.Globalization;
    using System.Runtime.InteropServices;
    using System.Security;

    [StructLayout(LayoutKind.Sequential)]
    public struct Single : IComparable, IComparable<float>, IEquatable<float>, IFormattable
    {
        public const float MinValue = -3.402823E+38f;
        public const float Epsilon = 1.401298E-45f;
        public const float MaxValue = 3.402823E+38f;
        public const float PositiveInfinity = (float) 1.0 / (float) 0.0;
        public const float NegativeInfinity = (float) -1.0 / (float) 0.0;
        public const float NaN = (float) 1.0 / (float) 0.0;
        public int CompareTo(float value)
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            return 0;
        }

        public bool Equals(float obj)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public override int GetHashCode()
        {
            return 0;
        }

        [SecuritySafeCritical]
        public static bool IsInfinity(float f)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public static bool IsNaN(float f)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public static bool IsNegativeInfinity(float f)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public static bool IsPositiveInfinity(float f)
        {
            return 0;
        }

        public static bool operator ==(float left, float right)
        {
            return 0;
        }

        public static bool operator >(float left, float right)
        {
            return 0;
        }

        public static bool operator >=(float left, float right)
        {
            return 0;
        }

        public static bool operator !=(float left, float right)
        {
            return 0;
        }

        public static bool operator <(float left, float right)
        {
            return 0;
        }

        public static bool operator <=(float left, float right)
        {
            return 0;
        }

        public static float Parse(string s)
        {
            return 0f;
        }

        public static float Parse(string s, NumberStyles style)
        {
            return 0f;
        }

        public static float Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return 0f;
        }

        public static float Parse(string s, IFormatProvider provider)
        {
            return 0f;
        }

        int IComparable.CompareTo(object value)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public override string ToString()
        {
            return null;
        }

        [SecuritySafeCritical]
        public string ToString(IFormatProvider provider)
        {
            return null;
        }

        [SecuritySafeCritical]
        public string ToString(string format)
        {
            return null;
        }

        [SecuritySafeCritical]
        public string ToString(string format, IFormatProvider provider)
        {
            return null;
        }

        public static unsafe bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result)
        {
            *((float*) result) = 0f;
            return 0;
        }

        public static unsafe bool TryParse(string s, out float result)
        {
            *((float*) result) = 0f;
            return 0;
        }
    }
}

