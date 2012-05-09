namespace System
{
    using System.Globalization;
    using System.Runtime.InteropServices;
    using System.Security;

    [StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct UInt32 : IComparable, IComparable<uint>, IEquatable<uint>, IFormattable
    {
        public const uint MaxValue = 0xffffffff;
        public const uint MinValue = 0;
        public int CompareTo(uint value)
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            return 0;
        }

        public bool Equals(uint obj)
        {
            return 0;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        [CLSCompliant(false)]
        public static uint Parse(string s)
        {
            return 0;
        }

        [CLSCompliant(false)]
        public static uint Parse(string s, NumberStyles style)
        {
            return 0;
        }

        [CLSCompliant(false)]
        public static uint Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return 0;
        }

        [CLSCompliant(false)]
        public static uint Parse(string s, IFormatProvider provider)
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

        [CLSCompliant(false)]
        public static unsafe bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result)
        {
            *((int*) result) = 0;
            return 0;
        }

        [CLSCompliant(false)]
        public static unsafe bool TryParse(string s, out uint result)
        {
            *((int*) result) = 0;
            return 0;
        }
    }
}

