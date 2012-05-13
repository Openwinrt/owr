namespace System
{
    public class ObjectDisposedException : InvalidOperationException
    {
        public ObjectDisposedException(string objectName)
        {
            base..ctor();
            return;
        }

        public ObjectDisposedException(string message, Exception innerException)
        {
            base..ctor();
            return;
        }

        public ObjectDisposedException(string objectName, string message)
        {
            base..ctor();
            return;
        }

        public override string Message
        {
            get
            {
                return null;
            }
        }

        public string ObjectName
        {
            get
            {
                return null;
            }
        }
    }
}

