namespace System.Collections.Generic
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct KeyValuePair<TKey, TValue>
    {
        public KeyValuePair(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public TKey Key
        {
            get
            {
                TKey local;
                return default(TKey);
            }
        }
        public TValue Value
        {
            get
            {
                TValue local;
                return default(TValue);
            }
        }
        public override string ToString()
        {
            return null;
        }
    }
}

