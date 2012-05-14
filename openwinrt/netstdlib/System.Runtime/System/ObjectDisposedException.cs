namespace System
{
    public class ObjectDisposedException : InvalidOperationException
    {
        // Does not override the HResult from InvalidOperationException

        private string obj_name;
        private string msg;

        // Constructors
        public ObjectDisposedException(string objectName)
            : base(Locale.GetText("The object was used after being disposed."))
        {
            obj_name = objectName;
            msg = Locale.GetText("The object was used after being disposed.");
        }

        public ObjectDisposedException(string objectName, string message)
            : base(message)
        {
            obj_name = objectName;
            msg = message;
        }

        public ObjectDisposedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        // Properties
        public override string Message
        {
            get { return msg; }
        }

        public string ObjectName
        {
            get { return obj_name; }
        }

    }
}

