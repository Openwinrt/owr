namespace System
{
    using System.Runtime.InteropServices;
    using System.Security;

    [StructLayout(LayoutKind.Sequential)]
    public struct IntPtr
    {
        public static readonly IntPtr Zero;
        [SecuritySafeCritical]
        public IntPtr(int value)
        {
            throw new NotImplementedException();
        }

        [SecuritySafeCritical]
        public IntPtr(long value)
        {
            throw new NotImplementedException();
        }

        [CLSCompliant(false), SecurityCritical]
        public unsafe IntPtr(void* value)
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
        public static IntPtr Add(IntPtr pointer, int offset)
        {
            IntPtr ptr;
            return new IntPtr();
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

        public static IntPtr operator +(IntPtr pointer, int offset)
        {
            IntPtr ptr;
            return new IntPtr();
        }

        [SecuritySafeCritical]
        public static bool operator ==(IntPtr value1, IntPtr value2)
        {
            return 0;
        }

        public static explicit operator IntPtr(int value)
        {
            IntPtr ptr;
            return new IntPtr();
        }

        public static explicit operator IntPtr(long value)
        {
            IntPtr ptr;
            return new IntPtr();
        }

        [SecuritySafeCritical]
        public static explicit operator int(IntPtr value)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public static explicit operator long(IntPtr value)
        {
            return 0L;
        }

        [CLSCompliant(false), SecuritySafeCritical]
        public static unsafe explicit operator void*(IntPtr value)
        {
            return (IntPtr) 0;
        }

        [CLSCompliant(false), SecurityCritical]
        public static unsafe explicit operator IntPtr(void* value)
        {
            IntPtr ptr;
            return new IntPtr();
        }

        [SecuritySafeCritical]
        public static bool operator !=(IntPtr value1, IntPtr value2)
        {
            return 0;
        }

        public static IntPtr operator -(IntPtr pointer, int offset)
        {
            IntPtr ptr;
            return new IntPtr();
        }

        public static IntPtr Subtract(IntPtr pointer, int offset)
        {
            IntPtr ptr;
            return new IntPtr();
        }

        [SecuritySafeCritical]
        public int ToInt32()
        {
            return 0;
        }

        [SecuritySafeCritical]
        public long ToInt64()
        {
            return 0L;
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
        public string ToString(string format)
        {
            return null;
        }
    }
}

