namespace System
{
    public class PlatformNotSupportedException : NotSupportedException
    {
        const int Result = unchecked((int)0x80131539);

        // Constructors
        public PlatformNotSupportedException()
            : base(Locale.GetText("This platform is not supported."))
        {
            HResult = Result;
        }

        public PlatformNotSupportedException(string message)
            : base(message)
        {
            HResult = Result;
        }

     
        public PlatformNotSupportedException(string message, Exception inner)
            : base(message, inner)
        {
            HResult = Result;
        }
    }
}

