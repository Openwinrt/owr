namespace Windows.Foundation.Metadata
{
    using System;
    using System.Runtime.CompilerServices;

    [Version(0x6020000), Windows.Foundation.Metadata.AttributeUsage(Windows.Foundation.Metadata.AttributeTargets.RuntimeClass)]
    public sealed class DualApiPartitionAttribute : Attribute
    {
        public uint version;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DualApiPartitionAttribute();
    }
}

