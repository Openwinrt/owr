namespace System
{
    public class InvalidTimeZoneException : Exception
    {
        public InvalidTimeZoneException()
            : base()
        { }

        public InvalidTimeZoneException(string message)
            : base(message)
        { }

        public InvalidTimeZoneException(string message, Exception innerException)
            : base(message, innerException)
        { }

    }
}

