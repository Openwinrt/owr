namespace System
{
    using System.Globalization;
    using System.Runtime.InteropServices;
    using System.Security;

    [StructLayout(LayoutKind.Sequential)]
    public struct Int64 : IComparable, IComparable<long>, IEquatable<long>, IFormattable
    {
        public const long MaxValue = 0x7fffffffffffffffL;
        public const long MinValue = -9223372036854775808L;
        public int CompareTo(long value)
        {
            return 0;
        }

        public bool Equals(long obj)
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            return 0;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public static long Parse(string s)
        {
            return 0L;
        }

        public static long Parse(string s, NumberStyles style)
        {
            return 0L;
        }

        public static long Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return 0L;
        }

        public static long Parse(string s, IFormatProvider provider)
        {
            return 0L;
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

        public static unsafe bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result)
        {
            *((long*) result) = 0L;
            return 0;
        }

        public static unsafe bool TryParse(string s, out long result)
        {
            *((long*) result) = 0L;
            return 0;
        }
    }
}

