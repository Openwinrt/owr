namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(IClipboardStatics), 0x6020000), DualApiPartition(version=0x6020000)]
    public static class Clipboard
    {
        public static  event Windows.Foundation.EventHandler<object> ContentChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void Flush();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static DataPackageView GetContent();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetContent([In] DataPackage content);
    }
}

