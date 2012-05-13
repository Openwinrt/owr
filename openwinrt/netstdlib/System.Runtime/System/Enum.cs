//
// System.Enum.cs
//
// Authors:
//   Miguel de Icaza (miguel@ximian.com)
//   Nick Drochak (ndrochak@gol.com)
//   Gonzalo Paniagua Javier (gonzalo@ximian.com)
//
// (C) Ximian, Inc.  http://www.ximian.com
//
//

//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//


namespace System
{
    internal struct MonoEnumInfo
    {
        internal Type utype;
        internal Array values;
        internal string[] names;
        internal Hashtable name_hash;
        [ThreadStatic]
        static Hashtable cache;
        static Hashtable global_cache;
        static object global_cache_monitor;

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private static extern void get_enum_info(Type enumType, out MonoEnumInfo info);

        //
        // These comparers are needed because enumerations must be compared
        // using unsigned values so that negative numbers can be looked up
        // See bug: #371559
        //
        internal static SByteComparer sbyte_comparer = new SByteComparer();
        internal static ShortComparer short_comparer = new ShortComparer();
        internal static IntComparer int_comparer = new IntComparer();
        internal static LongComparer long_comparer = new LongComparer();

        internal class SByteComparer : IComparer, System.Collections.Generic.IComparer<sbyte>
        {
            public int Compare(object x, object y)
            {
                sbyte ix = (sbyte)x;
                sbyte iy = (sbyte)y;

                return ((byte)ix) - ((byte)iy);
            }

            public int Compare(sbyte ix, sbyte iy)
            {
                return ((byte)ix) - ((byte)iy);
            }
        }

        internal class ShortComparer : IComparer, System.Collections.Generic.IComparer<short>
        {
            public int Compare(object x, object y)
            {
                short ix = (short)x;
                short iy = (short)y;

                return ((ushort)ix) - ((ushort)iy);
            }

            public int Compare(short ix, short iy)
            {
                return ((ushort)ix) - ((ushort)iy);
            }
        }

        internal class IntComparer : IComparer, System.Collections.Generic.IComparer<int>
        {
            public int Compare(object x, object y)
            {
                int ix = (int)x;
                int iy = (int)y;

                if (ix == iy)
                    return 0;

                if (((uint)ix) < ((uint)iy))
                    return -1;
                return 1;
            }

            public int Compare(int ix, int iy)
            {
                if (ix == iy)
                    return 0;

                if (((uint)ix) < ((uint)iy))
                    return -1;
                return 1;
            }
        }

        internal class LongComparer : IComparer, System.Collections.Generic.IComparer<long>
        {
            public int Compare(object x, object y)
            {
                long ix = (long)x;
                long iy = (long)y;

                if (ix == iy)
                    return 0;
                if (((ulong)ix) < ((ulong)iy))
                    return -1;
                return 1;
            }

            public int Compare(long ix, long iy)
            {
                if (ix == iy)
                    return 0;
                if (((ulong)ix) < ((ulong)iy))
                    return -1;
                return 1;
            }
        }

        static MonoEnumInfo()
        {
            global_cache_monitor = new object();
            global_cache = new Hashtable();
        }

        static Hashtable Cache
        {
            get
            {
                if (cache == null)
                {
                    cache = new Hashtable();
                }
                return cache;
            }
        }
        private MonoEnumInfo(MonoEnumInfo other)
        {
            utype = other.utype;
            values = other.values;
            names = other.names;
            name_hash = other.name_hash;
        }

        internal static void GetInfo(Type enumType, out MonoEnumInfo info)
        {
            /* First check the thread-local cache without locking */
            if (Cache.ContainsKey(enumType))
            {
                info = (MonoEnumInfo)cache[enumType];
                return;
            }
            /* Threads could die, so keep a global cache too */
            lock (global_cache_monitor)
            {
                if (global_cache.ContainsKey(enumType))
                {
                    object boxedInfo = global_cache[enumType];
                    cache[enumType] = boxedInfo;
                    info = (MonoEnumInfo)boxedInfo;
                    return;
                }
            }

            get_enum_info(enumType, out info);

            IComparer ic = null;
            Type et = Enum.GetUnderlyingType(enumType);
            if (et == typeof(int))
                ic = int_comparer;
            else if (et == typeof(short))
                ic = short_comparer;
            else if (et == typeof(sbyte))
                ic = sbyte_comparer;
            else if (et == typeof(long))
                ic = long_comparer;

            Array.Sort(info.values, info.names, ic);
            if (info.names.Length > 50)
            {
                info.name_hash = new Hashtable(info.names.Length);
                for (int i = 0; i < info.names.Length; ++i)
                    info.name_hash[info.names[i]] = i;
            }
            MonoEnumInfo cached = new MonoEnumInfo(info);
            lock (global_cache_monitor)
            {
                global_cache[enumType] = cached;
            }
        }
    };


    public abstract class Enum : ValueType, IComparable, IFormattable
    {
        protected Enum()
        {
         
        }

        [SecuritySafeCritical]
        public int CompareTo(object target)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public override bool Equals(object obj)
        {
            return 0;
        }

        public static string Format(Type enumType, object value, string format)
        {
            return null;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public static string GetName(Type enumType, object value)
        {
            return null;
        }

        public static string[] GetNames(Type enumType)
        {
            return null;
        }

        public static Type GetUnderlyingType(Type enumType)
        {
            return null;
        }

        public static Array GetValues(Type enumType)
        {
            return null;
        }

        [SecuritySafeCritical]
        public bool HasFlag(Enum flag)
        {
            return 0;
        }

        public static bool IsDefined(Type enumType, object value)
        {
            return 0;
        }

        public static object Parse(Type enumType, string value)
        {
            return null;
        }

        public static object Parse(Type enumType, string value, bool ignoreCase)
        {
            return null;
        }

        [Obsolete("The provider argument is not used. Please use ToString(String).")]
        string IFormattable.ToString(string format, IFormatProvider provider)
        {
            return null;
        }

        public static object ToObject(Type enumType, object value)
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

        public static bool TryParse<TEnum>(string value, out TEnum result) where TEnum: struct
        {
            result = default(TEnum);
            return 0;
        }

        public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum: struct
        {
            result = default(TEnum);
            return 0;
        }
    }
}

