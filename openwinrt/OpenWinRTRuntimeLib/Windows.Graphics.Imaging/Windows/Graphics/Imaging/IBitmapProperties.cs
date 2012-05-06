namespace Windows.Graphics.Imaging
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xea9f4f1b, 0xb505, 0x4450, 0xa4, 0xd1, 0xe8, 0xca, 0x94, 0x52, 0x9d, 0x8d), Version(0x6020000), ExclusiveTo(typeof(BitmapProperties))]
    internal interface IBitmapProperties : IBitmapPropertiesView
    {
        IAsyncAction SetPropertiesAsync([In] IIterable<IKeyValuePair<string, BitmapTypedValue>> propertiesToSet);
    }
}

