namespace Windows.Graphics.Imaging
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x7e0fe87a, 0x3a70, 0x48f8, 0x9c, 0x55, 0x19, 0x6c, 0xf5, 0xa5, 0x45, 0xf5)]
    public interface IBitmapPropertiesView
    {
        IAsyncOperation<IMap<string, BitmapTypedValue>> GetPropertiesAsync([In] IIterable<string> propertiesToRetrieve);
    }
}

