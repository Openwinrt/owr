namespace System
{
    using System.Globalization;
    using System.Runtime.InteropServices;
    using System.Security;

    [StructLayout(LayoutKind.Sequential)]
    public struct Int32 : IComparable, IComparable<int>, IEquatable<int>, IFormattable
    {
        public const int MaxValue = 0x7fffffff;
        public const int MinValue = -2147483648;
        public int CompareTo(int value)
        {
            return 0;
        }

        public bool Equals(int obj)
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

        public static int Parse(string s)
        {
            return 0;
        }

        public static int Parse(string s, NumberStyles style)
        {
            return 0;
        }

        public static int Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return 0;
        }

        public static int Parse(string s, IFormatProvider provider)
        {
            return 0;
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

        public static unsafe bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result)
        {
            *((int*) result) = 0;
            return 0;
        }

        public static unsafe bool TryParse(string s, out int result)
        {
            *((int*) result) = 0;
            return 0;
        }
    }
}

