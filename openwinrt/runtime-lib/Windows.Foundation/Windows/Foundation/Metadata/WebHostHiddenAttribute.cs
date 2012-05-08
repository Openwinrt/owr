namespace Windows.Foundation.Metadata
{
    using System;
    using System.Runtime.CompilerServices;

    [Windows.Foundation.Metadata.AttributeUsage(Windows.Foundation.Metadata.AttributeTargets.InterfaceGroup | Windows.Foundation.Metadata.AttributeTargets.Struct | Windows.Foundation.Metadata.AttributeTargets.RuntimeClass | Windows.Foundation.Metadata.AttributeTargets.Delegate | Windows.Foundation.Metadata.AttributeTargets.Enum | Windows.Foundation.Metadata.AttributeTargets.Interface), Version(0x6020000)]
    public sealed class WebHostHiddenAttribute : Attribute
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public WebHostHiddenAttribute();
    }
}

