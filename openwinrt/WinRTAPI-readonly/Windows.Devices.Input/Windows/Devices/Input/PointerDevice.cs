namespace Windows.Devices.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Static(typeof(IPointerDeviceStatics), 0x6020000), Version(0x6020000)]
    public sealed class PointerDevice : IPointerDevice
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static PointerDevice GetPointerDevice([In] uint pointerId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IVectorView<PointerDevice> GetPointerDevices();

        public bool IsIntegrated { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint MaxContacts { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Rect PhysicalDeviceRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Input.PointerDeviceType PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Rect ScreenRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<PointerDeviceUsage> SupportedUsages { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Devices.Input.IPointerDevice.IsIntegrated { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Devices.Input.IPointerDevice.MaxContacts { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Rect Windows.Devices.Input.IPointerDevice.PhysicalDeviceRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Devices.Input.PointerDeviceType Windows.Devices.Input.IPointerDevice.PointerDeviceType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Rect Windows.Devices.Input.IPointerDevice.ScreenRect { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVectorView<PointerDeviceUsage> Windows.Devices.Input.IPointerDevice.SupportedUsages { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

