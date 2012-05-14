namespace System
{
    [AttributeUsage(0x40)]
    public sealed class STAThreadAttribute : Attribute
    {
        public STAThreadAttribute()
        {
            base..ctor();
            return;
        }
    }
}

