namespace System
{
    public class Exception
    {
        public Exception()
        {
         
        }

        public Exception(string message)
        {
            base..ctor();
            return;
        }

        public Exception(string message, Exception innerException)
        {
            base..ctor();
            return;
        }

        public virtual Exception GetBaseException()
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        public virtual string HelpLink
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public int HResult
        {
            get
            {
                return 0;
            }
            protected set
            {
            }
        }

        public Exception InnerException
        {
            get
            {
                return null;
            }
        }

        public virtual string Message
        {
            get
            {
                return null;
            }
        }

        public virtual string Source
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public virtual string StackTrace
        {
            get
            {
                return null;
            }
        }
    }
}

