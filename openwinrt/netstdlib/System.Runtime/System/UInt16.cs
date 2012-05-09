namespace System
{
    using System.Globalization;
    using System.Runtime.InteropServices;
    using System.Security;

    [StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct UInt16 : IComparable, IComparable<ushort>, IEquatable<ushort>, IFormattable
    {
        public const ushort MaxValue = 0xffff;
        public const ushort MinValue = 0;
        public int CompareTo(ushort value)
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            return 0;
        }

        public bool Equals(ushort obj)
        {
            return 0;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        [CLSCompliant(false)]
        public static ushort Parse(string s)
        {
            return 0;
        }

        [CLSCompliant(false)]
        public static ushort Parse(string s, NumberStyles style)
        {
            return 0;
        }

        [CLSCompliant(false)]
        public static ushort Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return 0;
        }

        [CLSCompliant(false)]
        public static ushort Parse(string s, IFormatProvider provider)
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
        public static unsafe bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result)
        {
            *((short*) result) = 0;
            return 0;
        }

        [CLSCompliant(false)]
        public static unsafe bool TryParse(string s, out ushort result)
        {
            *((short*) result) = 0;
            return 0;
        }
    }
}

