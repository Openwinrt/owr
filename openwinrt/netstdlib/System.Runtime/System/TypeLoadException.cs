namespace System
{
    using System.Security;

    public class TypeLoadException : Exception
    {
        public TypeLoadException()
        {
            base..ctor();
            return;
        }

        public TypeLoadException(string message)
        {
            base..ctor();
            return;
        }

        public TypeLoadException(string message, Exception inner)
        {
            base..ctor();
            return;
        }

        public override string Message
        {
            [SecuritySafeCritical]
            get
            {
                return null;
            }
        }

        public string TypeName
        {
            get
            {
                return null;
            }
        }
    }
}

