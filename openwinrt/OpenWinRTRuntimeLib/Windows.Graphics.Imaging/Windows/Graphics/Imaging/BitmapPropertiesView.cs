namespace Windows.Graphics.Imaging
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class BitmapPropertiesView : IBitmapPropertiesView
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncOperation<IMap<string, BitmapTypedValue>> GetPropertiesAsync([In] IIterable<string> propertiesToRetrieve);
    }
}

