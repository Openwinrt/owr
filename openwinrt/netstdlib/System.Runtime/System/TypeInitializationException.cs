namespace System
{
    public sealed class TypeInitializationException : Exception
    {
        public TypeInitializationException(string fullTypeName, Exception innerException)
        {
            base..ctor();
            return;
        }

        public string TypeName
        {
            get
            {
                return null;
            }
        }
    }
}

