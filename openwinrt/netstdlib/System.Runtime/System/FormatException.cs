namespace System
{
    public class FormatException : Exception //IN mono its a system exception
    {
        const int Result = unchecked((int)0x80131537);

        public FormatException()
            : base(Locale.GetText("Invalid format."))
        {
            HResult = Result;
        }


        public FormatException(string message)
            : base(message)
        {
            HResult = Result;
        }

        public FormatException(string message, Exception innerException)
            : base(message, innerException)
        {
            HResult = Result;
        }
    }
}

