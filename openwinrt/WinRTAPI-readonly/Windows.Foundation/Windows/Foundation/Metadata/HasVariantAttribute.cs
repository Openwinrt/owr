namespace Windows.Foundation.Metadata
{
    using System;
    using System.Runtime.CompilerServices;

    [Windows.Foundation.Metadata.AttributeUsage(0xffffffff), Version(0x6020000)]
    public sealed class HasVariantAttribute : Attribute
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public HasVariantAttribute();
    }
}

