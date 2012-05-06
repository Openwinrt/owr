namespace Windows.Foundation.Metadata
{
    using System;
    using System.Runtime.CompilerServices;

    [Windows.Foundation.Metadata.AttributeUsage(Windows.Foundation.Metadata.AttributeTargets.Parameter), Version(0x6020000)]
    public sealed class LengthIsAttribute : Attribute
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public LengthIsAttribute(int indexLengthParameter);
    }
}

