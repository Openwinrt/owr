namespace System.Text
{
    using System;
    using System.Reflection;
    using System.Security;

    public sealed class StringBuilder
    {
        public StringBuilder()
        {
            base..ctor();
            return;
        }

        public StringBuilder(int capacity)
        {
            base..ctor();
            return;
        }

        public StringBuilder(string value)
        {
            base..ctor();
            return;
        }

        public StringBuilder(int capacity, int maxCapacity)
        {
            base..ctor();
            return;
        }

        public StringBuilder(string value, int capacity)
        {
            base..ctor();
            return;
        }

        [SecuritySafeCritical]
        public StringBuilder(string value, int startIndex, int length, int capacity)
        {
            base..ctor();
            return;
        }

        public StringBuilder Append(bool value)
        {
            return null;
        }

        public StringBuilder Append(byte value)
        {
            return null;
        }

        public StringBuilder Append(char value)
        {
            return null;
        }

        public StringBuilder Append(decimal value)
        {
            return null;
        }

        [SecuritySafeCritical]
        public StringBuilder Append(char[] value)
        {
            return null;
        }

        public StringBuilder Append(double value)
        {
            return null;
        }

        public StringBuilder Append(short value)
        {
            return null;
        }

        public StringBuilder Append(int value)
        {
            return null;
        }

        public StringBuilder Append(long value)
        {
            return null;
        }

        public StringBuilder Append(object value)
        {
            return null;
        }

        [CLSCompliant(false)]
        public StringBuilder Append(sbyte value)
        {
            return null;
        }

        public StringBuilder Append(float value)
        {
            return null;
        }

        [SecuritySafeCritical]
        public StringBuilder Append(string value)
        {
            return null;
        }

        [CLSCompliant(false)]
        public StringBuilder Append(ushort value)
        {
            return null;
        }

        [CLSCompliant(false)]
        public StringBuilder Append(uint value)
        {
            return null;
        }

        [CLSCompliant(false)]
        public StringBuilder Append(ulong value)
        {
            return null;
        }

        public StringBuilder Append(char value, int repeatCount)
        {
            return null;
        }

        [SecuritySafeCritical]
        public StringBuilder Append(string value, int startIndex, int count)
        {
            return null;
        }

        [SecuritySafeCritical]
        public StringBuilder Append(char[] value, int startIndex, int charCount)
        {
            return null;
        }

        public StringBuilder AppendFormat(string format, params object[] args)
        {
            return null;
        }

        public StringBuilder AppendFormat(IFormatProvider provider, string format, params object[] args)
        {
            return null;
        }

        public StringBuilder AppendLine()
        {
            return null;
        }

        public StringBuilder AppendLine(string value)
        {
            return null;
        }

        public StringBuilder Clear()
        {
            return null;
        }

        [SecuritySafeCritical]
        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
        }

        public int EnsureCapacity(int capacity)
        {
            return 0;
        }

        public bool Equals(StringBuilder sb)
        {
            return 0;
        }

        public StringBuilder Insert(int index, bool value)
        {
            return null;
        }

        public StringBuilder Insert(int index, byte value)
        {
            return null;
        }

        [SecuritySafeCritical]
        public StringBuilder Insert(int index, char value)
        {
            return null;
        }

        public StringBuilder Insert(int index, char[] value)
        {
            return null;
        }

        public StringBuilder Insert(int index, decimal value)
        {
            return null;
        }

        public StringBuilder Insert(int index, double value)
        {
            return null;
        }

        public StringBuilder Insert(int index, short value)
        {
            return null;
        }

        public StringBuilder Insert(int index, int value)
        {
            return null;
        }

        public StringBuilder Insert(int index, long value)
        {
            return null;
        }

        public StringBuilder Insert(int index, object value)
        {
            return null;
        }

        [CLSCompliant(false)]
        public StringBuilder Insert(int index, sbyte value)
        {
            return null;
        }

        public StringBuilder Insert(int index, float value)
        {
            return null;
        }

        [SecuritySafeCritical]
        public StringBuilder Insert(int index, string value)
        {
            return null;
        }

        [CLSCompliant(false)]
        public StringBuilder Insert(int index, ushort value)
        {
            return null;
        }

        [CLSCompliant(false)]
        public StringBuilder Insert(int index, uint value)
        {
            return null;
        }

        [CLSCompliant(false)]
        public StringBuilder Insert(int index, ulong value)
        {
            return null;
        }

        [SecuritySafeCritical]
        public StringBuilder Insert(int index, string value, int count)
        {
            return null;
        }

        [SecuritySafeCritical]
        public StringBuilder Insert(int index, char[] value, int startIndex, int charCount)
        {
            return null;
        }

        public StringBuilder Remove(int startIndex, int length)
        {
            return null;
        }

        public StringBuilder Replace(char oldChar, char newChar)
        {
            return null;
        }

        public StringBuilder Replace(string oldValue, string newValue)
        {
            return null;
        }

        public StringBuilder Replace(char oldChar, char newChar, int startIndex, int count)
        {
            return null;
        }

        public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count)
        {
            return null;
        }

        [SecuritySafeCritical]
        public override string ToString()
        {
            return null;
        }

        [SecuritySafeCritical]
        public string ToString(int startIndex, int length)
        {
            return null;
        }

        public int Capacity
        {
            get
            {
                return 0;
            }
            set
            {
            }
        }

        public char this[int index]
        {
            get
            {
                return 0;
            }
            set
            {
            }
        }

        public int Length
        {
            get
            {
                return 0;
            }
            set
            {
            }
        }

        public int MaxCapacity
        {
            get
            {
                return 0;
            }
        }
    }
}

