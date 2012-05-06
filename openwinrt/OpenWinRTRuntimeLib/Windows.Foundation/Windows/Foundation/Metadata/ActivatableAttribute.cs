namespace Windows.Foundation.Metadata
{
    using System;
    using System.Runtime.CompilerServices;

    [AllowMultiple, Windows.Foundation.Metadata.AttributeUsage(Windows.Foundation.Metadata.AttributeTargets.RuntimeClass), Version(0x6020000)]
    public sealed class ActivatableAttribute : Attribute
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ActivatableAttribute(uint version);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ActivatableAttribute(Type type, uint version);
    }
}

