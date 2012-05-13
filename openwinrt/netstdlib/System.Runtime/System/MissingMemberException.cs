namespace System
{
    using System.Security;

    public class MissingMemberException : MemberAccessException
    {
        public MissingMemberException()
        {
            base..ctor();
            return;
        }

        public MissingMemberException(string message)
        {
            base..ctor();
            return;
        }

        public MissingMemberException(string message, Exception inner)
        {
            base..ctor();
            return;
        }

        public override string Message
        {
            [SecuritySafeCritical]
            get
            {
                return null;
            }
        }
    }
}

