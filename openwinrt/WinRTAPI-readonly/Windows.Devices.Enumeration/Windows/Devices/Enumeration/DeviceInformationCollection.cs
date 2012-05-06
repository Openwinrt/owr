namespace Windows.Devices.Enumeration
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class DeviceInformationCollection : IVectorView<DeviceInformation>, IIterable<DeviceInformation>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<DeviceInformation> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DeviceInformation GetAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public uint GetMany([In] uint startIndex, [Out] DeviceInformation[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IndexOf([In] DeviceInformation value, out uint index);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

