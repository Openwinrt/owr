namespace System
{
    using System.Runtime.InteropServices;
    using System.Security;

    [StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct UIntPtr
    {
        public static readonly UIntPtr Zero;
        [SecuritySafeCritical]
        public UIntPtr(uint value)
        {
            throw new NotImplementedException();
        }

        [SecuritySafeCritical]
        public UIntPtr(ulong value)
        {
            throw new NotImplementedException();
        }

        [SecurityCritical, CLSCompliant(false)]
        public unsafe UIntPtr(void* value)
        {
            throw new NotImplementedException();
        }

        public static int Size
        {
            get
            {
                return 0;
            }
        }
        public static UIntPtr Add(UIntPtr pointer, int offset)
        {
            UIntPtr ptr;
            return new UIntPtr();
        }

        [SecuritySafeCritical]
        public override bool Equals(object obj)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public override int GetHashCode()
        {
            return 0;
        }

        public static UIntPtr operator +(UIntPtr pointer, int offset)
        {
            UIntPtr ptr;
            return new UIntPtr();
        }

        [SecuritySafeCritical]
        public static bool operator ==(UIntPtr value1, UIntPtr value2)
        {
            return 0;
        }

        public static explicit operator UIntPtr(uint value)
        {
            UIntPtr ptr;
            return new UIntPtr();
        }

        public static explicit operator UIntPtr(ulong value)
        {
            UIntPtr ptr;
            return new UIntPtr();
        }

        [SecuritySafeCritical]
        public static explicit operator uint(UIntPtr value)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public static explicit operator ulong(UIntPtr value)
        {
            return 0L;
        }

        [SecurityCritical, CLSCompliant(false)]
        public static unsafe explicit operator void*(UIntPtr value)
        {
            return (IntPtr) 0;
        }

        [CLSCompliant(false), SecurityCritical]
        public static unsafe explicit operator UIntPtr(void* value)
        {
            UIntPtr ptr;
            return new UIntPtr();
        }

        [SecuritySafeCritical]
        public static bool operator !=(UIntPtr value1, UIntPtr value2)
        {
            return 0;
        }

        public static UIntPtr operator -(UIntPtr pointer, int offset)
        {
            UIntPtr ptr;
            return new UIntPtr();
        }

        public static UIntPtr Subtract(UIntPtr pointer, int offset)
        {
            UIntPtr ptr;
            return new UIntPtr();
        }

        [CLSCompliant(false), SecuritySafeCritical]
        public unsafe void* ToPointer()
        {
            return (IntPtr) 0;
        }

        [SecuritySafeCritical]
        public override string ToString()
        {
            return null;
        }

        [SecuritySafeCritical]
        public uint ToUInt32()
        {
            return 0;
        }

        [SecuritySafeCritical]
        public ulong ToUInt64()
        {
            return 0L;
        }
    }
}

