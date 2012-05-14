namespace System
{
    public class NullReferenceException : Exception
    {
        const int Result = unchecked((int)0x80004003);

        // Constructors
        public NullReferenceException()
            : base(Locale.GetText("A null value was found where an object instance was required."))
        {
            HResult = Result;
        }

        public NullReferenceException(string message)
            : base(message)
        {
            HResult = Result;
        }

        public NullReferenceException(string message, Exception innerException)
            : base(message, innerException)
        {
            HResult = Result;
        }
    }
}

