namespace Windows.Foundation.Metadata
{
    using System;
    using System.Runtime.CompilerServices;

    [Windows.Foundation.Metadata.AttributeUsage(Windows.Foundation.Metadata.AttributeTargets.Method), Version(0x6020000)]
    public sealed class OverloadAttribute : Attribute
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public OverloadAttribute(string method);
    }
}

