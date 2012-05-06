namespace Windows.Foundation.Metadata
{
    using System;
    using System.Runtime.CompilerServices;

    [Windows.Foundation.Metadata.AttributeUsage(Windows.Foundation.Metadata.AttributeTargets.Parameter | Windows.Foundation.Metadata.AttributeTargets.Property), Version(0x6020000)]
    public sealed class VariantAttribute : Attribute
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public VariantAttribute();
    }
}

