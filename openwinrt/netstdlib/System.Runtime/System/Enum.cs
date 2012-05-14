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
            Type thisType;

            if (target == null)
                return 1;

            thisType = this.GetType();
            if (target.GetType() != thisType)
            {
                throw new ArgumentException(String.Format(
                    "Object must be the same type as the enum. The type passed in was {0}; the enum type was {1}.",
                    target.GetType(), thisType));
            }

            return compare_value_to(target);
        }

        [SecuritySafeCritical]
        public override bool Equals(object obj)
        {
            return DefaultEquals(this, obj);
        }

        public static string Format(Type enumType, object value, string format)
        {
            if (enumType == null)
                throw new ArgumentNullException("enumType");
            if (value == null)
                throw new ArgumentNullException("value");
            if (format == null)
                throw new ArgumentNullException("format");

            if (!enumType.IsEnum)
                throw new ArgumentException("enumType is not an Enum type.", "enumType");

            Type vType = value.GetType();
            Type underlyingType = Enum.GetUnderlyingType(enumType);
            if (vType.IsEnum)
            {
                if (vType != enumType)
                    throw new ArgumentException(string.Format(CultureInfo.InvariantCulture,
                        "Object must be the same type as the enum. The type" +
                        " passed in was {0}; the enum type was {1}.",
                        vType.FullName, enumType.FullName));
            }
            else if (vType != underlyingType)
            {
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture,
                    "Enum underlying type and the object must be the same type" +
                    " or object. Type passed in was {0}; the enum underlying" +
                    " type was {1}.", vType.FullName, underlyingType.FullName));
            }

            if (format.Length != 1)
                throw new FormatException("Format String can be only \"G\",\"g\",\"X\"," +
                    "\"x\",\"F\",\"f\",\"D\" or \"d\".");

            char formatChar = format[0];
            string retVal;
            if ((formatChar == 'G' || formatChar == 'g'))
            {
                if (!enumType.IsDefined(typeof(FlagsAttribute), false))
                {
                    retVal = GetName(enumType, value);
                    if (retVal == null)
                        retVal = value.ToString();

                    return retVal;
                }

                formatChar = 'f';
            }

            if ((formatChar == 'f' || formatChar == 'F'))
                return FormatFlags(enumType, value);

            retVal = String.Empty;
            switch (formatChar)
            {
                case 'X':
                    retVal = FormatSpecifier_X(enumType, value, true);
                    break;
                case 'x':
                    retVal = FormatSpecifier_X(enumType, value, false);
                    break;
                case 'D':
                case 'd':
                    if (underlyingType == typeof(ulong))
                    {
                        ulong ulongValue = Convert.ToUInt64(value);
                        retVal = ulongValue.ToString();
                    }
                    else
                    {
                        long longValue = Convert.ToInt64(value);
                        retVal = longValue.ToString();
                    }
                    break;
                default:
                    throw new FormatException("Format String can be only \"G\",\"g\",\"X\"," +
                        "\"x\",\"F\",\"f\",\"D\" or \"d\".");
            }
            return retVal;
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern int get_hashcode();

        public override int GetHashCode()
        {
            return get_hashcode();
        }

        public static string GetName(Type enumType, object value)
        {
            if (enumType == null)
                throw new ArgumentNullException("enumType");
            if (value == null)
                throw new ArgumentNullException("value");

            if (!enumType.IsEnum)
                throw new ArgumentException("enumType is not an Enum type.", "enumType");

            MonoEnumInfo info;
            value = ToObject(enumType, value);
            MonoEnumInfo.GetInfo(enumType, out info);

            int i = FindPosition(enumType, value, info.values);
            return (i >= 0) ? info.names[i] : null;
        }

        public static string[] GetNames(Type enumType)
        {
            if (enumType == null)
                throw new ArgumentNullException("enumType");

            if (!enumType.IsEnum)
                throw new ArgumentException("enumType is not an Enum type.");

            MonoEnumInfo info;
            MonoEnumInfo.GetInfo(enumType, out info);
            return (string[])info.names.Clone();
        }

        public static Type GetUnderlyingType(Type enumType)
        {
            if (enumType == null)
                throw new ArgumentNullException("enumType");

            if (!enumType.IsEnum)
                throw new ArgumentException("enumType is not an Enum type.", "enumType");

            return get_underlying_type(enumType);
        }

        public static Array GetValues(Type enumType)
        {
            if (enumType == null)
                throw new ArgumentNullException("enumType");

            if (!enumType.IsEnum)
                throw new ArgumentException("enumType is not an Enum type.", "enumType");

            MonoEnumInfo info;
            MonoEnumInfo.GetInfo(enumType, out info);
            return (Array)info.values.Clone();
        }

        [SecuritySafeCritical]
        public bool HasFlag(Enum flag)
        {
            var val = get_value();
            ulong mvalue = GetValue(val, Type.GetTypeCode(val.GetType()));
            ulong fvalue = GetValue(flag, Type.GetTypeCode(flag.GetType()));

            return ((mvalue & fvalue) == fvalue);
        }

        public static bool IsDefined(Type enumType, object value)
        {
            if (enumType == null)
                throw new ArgumentNullException("enumType");
            if (value == null)
                throw new ArgumentNullException("value");

            if (!enumType.IsEnum)
                throw new ArgumentException("enumType is not an Enum type.", "enumType");

            MonoEnumInfo info;
            MonoEnumInfo.GetInfo(enumType, out info);

            Type vType = value.GetType();
            if (vType == typeof(String))
            {
                return ((IList)(info.names)).Contains(value);
            }
            else if ((vType == info.utype) || (vType == enumType))
            {
                value = ToObject(enumType, value);
                MonoEnumInfo.GetInfo(enumType, out info);

                return FindPosition(enumType, value, info.values) >= 0;
            }
            else
            {
                throw new ArgumentException("The value parameter is not the correct type. "
                    + "It must be type String or the same type as the underlying type "
                    + "of the Enum.");
            }
        }

        public static object Parse(Type enumType, string value)
        {
            // Note: Parameters are checked in the other overload
            return Parse(enumType, value, false);
        }

        public static object Parse(Type enumType, string value, bool ignoreCase)
        {
            if (enumType == null)
                throw new ArgumentNullException("enumType");

            if (value == null)
                throw new ArgumentNullException("value");

            if (!enumType.IsEnum)
                throw new ArgumentException("enumType is not an Enum type.", "enumType");

            value = value.Trim();
            if (value.Length == 0)
                throw new ArgumentException("An empty string is not considered a valid value.");

            object result;
            if (!Parse(enumType, value, ignoreCase, out result))
                throw new ArgumentException(String.Format("The requested value '{0}' was not found.", value));

            return result;
        }

        [Obsolete("The provider argument is not used. Please use ToString(String).")]
        string IFormattable.ToString(string format, IFormatProvider provider)
        {
            return null;
        }

        //public static object ToObject(Type enumType, object value)
        //{
        //    return null;
        //}
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern object ToObject(Type enumType, object value);

        public override string ToString()
        {
            return ToString("G");
        }

        public string ToString(string format)
        {
            if (format == String.Empty || format == null)
                format = "G";

            return Format(this.GetType(), this.Value, format);
        }

        public static bool TryParse<TEnum>(string value, out TEnum result) where TEnum: struct
        {
            return TryParse(value, false, out result);
        }

        public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum: struct
        {
            Type tenum_type = typeof(TEnum);
            if (!tenum_type.IsEnum)
                throw new ArgumentException("TEnum is not an Enum type.", "enumType");

            result = default(TEnum);

            if (value == null || value.Trim().Length == 0)
                return false;

            return Parse(tenum_type, value, ignoreCase, out result);
        }
    }
}

