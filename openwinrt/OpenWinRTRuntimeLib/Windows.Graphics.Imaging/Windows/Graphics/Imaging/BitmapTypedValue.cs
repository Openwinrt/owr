namespace Windows.Graphics.Imaging
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Threading(ThreadingModel.Both), Activatable(typeof(IBitmapTypedValueFactory), 0x6020000)]
    public sealed class BitmapTypedValue : IBitmapTypedValue
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public BitmapTypedValue([In] object value, [In] PropertyType type);

        public PropertyType Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PropertyType Windows.Graphics.Imaging.IBitmapTypedValue.Type { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.Graphics.Imaging.IBitmapTypedValue.Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

