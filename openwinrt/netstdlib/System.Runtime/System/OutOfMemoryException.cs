namespace System
{
    public class OutOfMemoryException : Exception
    {
        const int Result = unchecked((int)0x8007000E);

        // Constructors
        public OutOfMemoryException()
            : base(Locale.GetText("Out of memory."))
        {
            HResult = Result;
        }

        public OutOfMemoryException(string message)
            : base(message)
        {
            HResult = Result;
        }

        public OutOfMemoryException(string message, Exception innerException)
            : base(message, innerException)
        {
            HResult = Result;
        }
    }
}

