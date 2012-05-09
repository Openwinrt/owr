namespace System
{
    using System.Security;

    public abstract class Type
    {
        public static readonly object Missing;

        internal Type()
        {
            base..ctor();
            return;
        }

        public override bool Equals(object o)
        {
            return 0;
        }

        public bool Equals(Type o)
        {
            return 0;
        }

        public abstract int GetArrayRank();
        public abstract Type GetElementType();
        public abstract Type GetGenericTypeDefinition();
        public override int GetHashCode()
        {
            return 0;
        }

        public static Type GetType(string typeName)
        {
            return null;
        }

        public static Type GetType(string typeName, bool throwOnError)
        {
            return null;
        }

        [SecuritySafeCritical]
        public static Type GetTypeFromHandle(RuntimeTypeHandle handle)
        {
            return null;
        }

        public abstract Type MakeArrayType();
        public abstract Type MakeArrayType(int rank);
        public abstract Type MakeByRefType();
        public abstract Type MakeGenericType(params Type[] typeArguments);
        public abstract Type MakePointerType();
        public override string ToString()
        {
            return null;
        }

        public abstract string AssemblyQualifiedName { get; }

        public abstract Type DeclaringType { get; }

        public abstract string FullName { get; }

        public abstract int GenericParameterPosition { get; }

        public abstract Type[] GenericTypeArguments { get; }

        public bool HasElementType
        {
            get
            {
                return 0;
            }
        }

        public bool IsArray
        {
            get
            {
                return 0;
            }
        }

        public bool IsByRef
        {
            get
            {
                return 0;
            }
        }

        public abstract bool IsConstructedGenericType { get; }

        public abstract bool IsGenericParameter { get; }

        public bool IsNested
        {
            get
            {
                return 0;
            }
        }

        public bool IsPointer
        {
            get
            {
                return 0;
            }
        }

        public abstract string Name { get; }

        public abstract string Namespace { get; }

        public virtual RuntimeTypeHandle TypeHandle
        {
            get
            {
                RuntimeTypeHandle handle;
                return new RuntimeTypeHandle();
            }
        }
    }
}

