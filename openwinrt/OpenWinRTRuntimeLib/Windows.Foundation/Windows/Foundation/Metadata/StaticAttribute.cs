namespace Windows.Foundation.Metadata
{
    using System;
    using System.Runtime.CompilerServices;

    [AllowMultiple, Windows.Foundation.Metadata.AttributeUsage(Windows.Foundation.Metadata.AttributeTargets.RuntimeClass), Version(0x6020000)]
    public sealed class StaticAttribute : Attribute
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public StaticAttribute(Type type, uint version);
    }
}

