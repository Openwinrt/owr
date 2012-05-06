namespace Windows.Foundation.Metadata
{
    using System;
    using System.Runtime.CompilerServices;

    [Version(0x6020000), Windows.Foundation.Metadata.AttributeUsage(Windows.Foundation.Metadata.AttributeTargets.Method | Windows.Foundation.Metadata.AttributeTargets.InterfaceGroup | Windows.Foundation.Metadata.AttributeTargets.Property | Windows.Foundation.Metadata.AttributeTargets.InterfaceImpl | Windows.Foundation.Metadata.AttributeTargets.Struct | Windows.Foundation.Metadata.AttributeTargets.RuntimeClass | Windows.Foundation.Metadata.AttributeTargets.Delegate | Windows.Foundation.Metadata.AttributeTargets.Enum | Windows.Foundation.Metadata.AttributeTargets.Interface | Windows.Foundation.Metadata.AttributeTargets.Field | Windows.Foundation.Metadata.AttributeTargets.Event)]
    public sealed class VersionAttribute : Attribute
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public VersionAttribute(uint version);
    }
}

