namespace System
{
    using System.Globalization;
    using System.Runtime.InteropServices;
    using System.Security;

    [StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct UInt64 : IComparable, IComparable<ulong>, IEquatable<ulong>, IFormattable
    {
        public const ulong MaxValue = 18446744073709551615L;
        public const ulong MinValue = 0L;
        public int CompareTo(ulong value)
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            return 0;
        }

        public bool Equals(ulong obj)
        {
            return 0;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        [CLSCompliant(false)]
        public static ulong Parse(string s)
        {
            return 0L;
        }

        [CLSCompliant(false)]
        public static ulong Parse(string s, NumberStyles style)
        {
            return 0L;
        }

        [CLSCompliant(false)]
        public static ulong Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return 0L;
        }

        [CLSCompliant(false)]
        public static ulong Parse(string s, IFormatProvider provider)
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

        [CLSCompliant(false)]
        public static unsafe bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result)
        {
            *((long*) result) = 0L;
            return 0;
        }

        [CLSCompliant(false)]
        public static unsafe bool TryParse(string s, out ulong result)
        {
            *((long*) result) = 0L;
            return 0;
        }
    }
}

