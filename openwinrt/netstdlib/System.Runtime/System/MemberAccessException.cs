namespace System
{
    public class MemberAccessException : Exception
    {
        const int Result = unchecked((int)0x8013151A);

        public MemberAccessException()
            : base(Locale.GetText("Cannot access a class member."))
        {
            HResult = Result;
        }

        public MemberAccessException(string message)
            : base(message)
        {
            HResult = Result;
        }

    
        public MemberAccessException(string message, Exception inner)
            : base(message, inner)
        {
            HResult = Result;
        }
    }
}

