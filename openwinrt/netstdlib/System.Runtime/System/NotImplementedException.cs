namespace System
{
    public class NotImplementedException : Exception
    {
        const int Result = unchecked((int)0x80004001);

        // Constructors
        public NotImplementedException()
            : base(Locale.GetText("The requested feature is not implemented."))
        {
            HResult = Result;
        }

        public NotImplementedException(string message)
            : base(message)
        {
            HResult = Result;
        }

        public NotImplementedException(string message, Exception inner)
            : base(message, inner)
        {
            HResult = Result;
        }
    }
}

