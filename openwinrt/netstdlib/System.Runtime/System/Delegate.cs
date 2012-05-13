using System.Security;

namespace System
{
    /* Contains the rarely used fields of Delegate */
    //TODO struct
    class DelegateData
    {
        public Type target_type;
        public string method_name;
    }
  

    public abstract class Delegate
    {
        #region Sync with object-internals.h
#pragma warning disable 169, 414, 649
        private IntPtr method_ptr;
        private IntPtr invoke_impl;
        private object m_target;
        private IntPtr method;
        private IntPtr delegate_trampoline;
        private IntPtr method_code;
        private MethodInfo method_info;

        // Keep a ref of the MethodInfo passed to CreateDelegate.
        // Used to keep DynamicMethods alive.
        private MethodInfo original_method_info;

        private DelegateData data;
#pragma warning restore 169, 414, 649
        #endregion



        internal Delegate()
        {
        }

        protected Delegate(object target, string method)
        {
            if (target == null)
                throw new ArgumentNullException("target");

            if (method == null)
                throw new ArgumentNullException("method");

            this.m_target = target;
            this.data = new DelegateData();
            this.data.method_name = method;
        }

        protected Delegate(Type target, string method)
        {
            if (target == null)
                throw new ArgumentNullException("target");

            if (method == null)
                throw new ArgumentNullException("method");

            this.data = new DelegateData();
            this.data.method_name = method;
            this.data.target_type = target;
        }

        /// <symmary>
        ///   Returns a new MulticastDelegate holding the
        ///   concatenated invocation lists of an Array of MulticastDelegates
        /// </symmary>
    //    [System.Runtime.InteropServices.ComVisible(true)]
        public static Delegate Combine(params Delegate[] delegates)
        {
            if (delegates == null)
                return null;

            Delegate retval = null;

            foreach (Delegate next in delegates)
                retval = Combine(retval, next);

            return retval;
        }

        /// <symmary>
        ///   Returns a new MulticastDelegate holding the
        ///   concatenated invocation lists of MulticastDelegates a and b
        /// </symmary>
        public static Delegate Combine(Delegate a, Delegate b)
        {
            if (a == null)
            {
                if (b == null)
                    return null;
                return b;
            }
            else
                if (b == null)
                    return a;

            if (a.GetType() != b.GetType())
                throw new ArgumentException(Locale.GetText("Incompatible Delegate Types."));

            return a.CombineImpl(b);
        }

        protected virtual Delegate CombineImpl(Delegate d)
        {
            throw new MulticastNotSupportedException(String.Empty);
        }

        public object DynamicInvoke(params object[] args)
        {
            return DynamicInvokeImpl(args);
        }

        protected virtual object DynamicInvokeImpl(object[] args)
        {
            if (Method == null)
            {
                Type[] mtypes = new Type[args.Length];
                for (int i = 0; i < args.Length; ++i)
                {
                    mtypes[i] = args[i].GetType();
                }
                method_info = m_target.GetType().GetMethod(data.method_name, mtypes);
            }

            if (Method.IsStatic && (args != null ? args.Length : 0) == Method.GetParameters().Length - 1)
            {
                // The delegate is bound to m_target
                if (args != null)
                {
                    object[] newArgs = new object[args.Length + 1];
                    args.CopyTo(newArgs, 1);
                    newArgs[0] = m_target;
                    args = newArgs;
                }
                else
                {
                    args = new object[] { m_target };
                }
                return Method.Invoke(null, args);
            }

            return Method.Invoke(m_target, args);
        }


        [SecuritySafeCritical]
        public override bool Equals(object obj)
        {
            Delegate d = obj as Delegate;

            if (d == null)
                return false;

            // Do not compare method_ptr, since it can point to a trampoline
            if (d.m_target == m_target && d.method == method)
            {
                if (d.data != null || data != null)
                {
                    /* Uncommon case */
                    if (d.data != null && data != null)
                        return (d.data.target_type == data.target_type && d.data.method_name == data.method_name);
                    else
                        return false;
                }
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return method.GetHashCode() ^ (m_target != null ? m_target.GetHashCode() : 0);
        }

        public virtual Delegate[] GetInvocationList()
        {
            return new Delegate[] { this };
        }

        public static bool operator ==(Delegate d1, Delegate d2)
        {
            if ((object)d1 == null)
            {
                if ((object)d2 == null)
                    return true;
                return false;
            }
            else if ((object)d2 == null)
                return false;

            return d1.Equals(d2);
        }

        public static bool operator !=(Delegate d1, Delegate d2)
        {
            return !(d1 == d2);
        }

        [SecuritySafeCritical]
        public static Delegate Remove(Delegate source, Delegate value)
        {
            if (source == null)
                return null;

            if (value == null)
                return source;

            if (source.GetType() != value.GetType())
                throw new ArgumentException("Delegate type mismatch");

            return source.RemoveImpl(value);
        }

        protected virtual Delegate RemoveImpl(Delegate d)
        {
            if (this.Equals(d))
                return null;

            return this;
        }

        public static Delegate RemoveAll(Delegate source, Delegate value)
        {
            Delegate tmp = source;
            while ((source = Delegate.Remove(source, value)) != tmp)
                tmp = source;

            return tmp;
        }

        public object Target
        {
            get
            {
                return m_target;
            }
        }
    }
}

