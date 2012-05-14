namespace System
{
    public sealed class IndexOutOfRangeException : Exception
    {
        // Constructors
        public IndexOutOfRangeException()
            : base(Locale.GetText("Array index is out of range."))
        {
        }

        public IndexOutOfRangeException(string message)
            : base(message)
        {
        }

        public IndexOutOfRangeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}

