namespace Windows.Foundation.Metadata
{
    using System;
    using System.Runtime.CompilerServices;

    [Windows.Foundation.Metadata.AttributeUsage(Windows.Foundation.Metadata.AttributeTargets.InterfaceImpl), Version(0x6020000)]
    public sealed class ProtectedAttribute : Attribute
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ProtectedAttribute();
    }
}

