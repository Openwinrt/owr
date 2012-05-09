using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace System.Runtime.System
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Guid : IComparable, IComparable<Guid>, IEquatable<Guid>, IFormattable
    {
        public static readonly Guid Empty;
        public Guid(byte[] b)
        {
            throw new NotImplementedException();
        }

        public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
        {
            throw new NotImplementedException();
        }

        public Guid(int a, short b, short c, byte[] d)
        {
            throw new NotImplementedException();
        }

        public Guid(string g)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Guid value)
        {
            return 0;
        }

        public bool Equals(Guid g)
        {
            return 0;
        }

        public override bool Equals(object o)
        {
            return 0;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        [SecuritySafeCritical]
        public static Guid NewGuid()
        {
            Guid guid;
            return new Guid();
        }

        public static bool operator ==(Guid a, Guid b)
        {
            return 0;
        }

        public static bool operator !=(Guid a, Guid b)
        {
            return 0;
        }

        public static Guid Parse(string input)
        {
            Guid guid;
            return new Guid();
        }

        public static Guid ParseExact(string input, string format)
        {
            Guid guid;
            return new Guid();
        }

        int IComparable.CompareTo(object value)
        {
            return 0;
        }

        string IFormattable.ToString(string format, IFormatProvider provider)
        {
            return null;
        }

        public byte[] ToByteArray()
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        public string ToString(string format)
        {
            return null;
        }

        public static bool TryParse(string input, out Guid result)
        {
            result = new Guid();
            return 0;
        }

        public static bool TryParseExact(string input, string format, out Guid result)
        {
            result = new Guid();
            return 0;
        }
    }
}
