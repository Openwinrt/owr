namespace System
{
    using System.Security;

    public abstract class ValueType
    {
        protected ValueType()
        {
      
        }

        public override bool Equals(object obj)
        {
            return DefaultEquals(this, obj);
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool InternalEquals(object o1, object o2, out object[] fields);

        // This is also used by RuntimeHelpers
        internal static bool DefaultEquals(object o1, object o2)
        {
            object[] fields;

            if (o2 == null)
                return false;

            bool res = InternalEquals(o1, o2, out fields);
            if (fields == null)
                return res;

            for (int i = 0; i < fields.Length; i += 2)
            {
                object meVal = fields[i];
                object youVal = fields[i + 1];
                if (meVal == null)
                {
                    if (youVal == null)
                        continue;

                    return false;
                }

                if (!meVal.Equals(youVal))
                    return false;
            }

            return true;
        }

        [SecuritySafeCritical]
        // <summary>
        //   Gets a hashcode for this value type using the
        //   bits in the structure
        // </summary>

        //TODO seems very expensive...
        public override int GetHashCode()
        {
            object[] fields;
            int result = InternalGetHashCode(this, out fields);

            if (fields != null)
                for (int i = 0; i < fields.Length; ++i)
                    if (fields[i] != null)
                        result ^= fields[i].GetHashCode();

            return result;
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        internal extern static int InternalGetHashCode(object o, out object[] fields);



        // <summary>
        //   Stringified representation of this ValueType.
        //   Must be overriden for better results, by default
        //   it just returns the Type name.
        // </summary>
        public override string ToString()
        {
            return GetType().FullName;
        }
    }
}

