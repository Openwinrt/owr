namespace System
{
    public class InvalidCastException : Exception //SystemException
    {
        const int Result = unchecked((int)0x80004002);

        // Constructors
        public InvalidCastException()
            : base(Locale.GetText("Cannot cast from source type to destination type."))
        {
            HResult = Result;
        }

        public InvalidCastException(string message)
            : base(message)
        {
            HResult = Result;
        }

        public InvalidCastException(string message, Exception innerException)
            : base(message, innerException)
        {
            HResult = Result;
        }

        public InvalidCastException(string message, int errorCode)
            : base(message)
        {
            HResult = errorCode;
        }
    }
}

