namespace Windows.UI.Xaml.Media.Animation
{
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(KeyTimeHelper)), Windows.Foundation.Metadata.Guid(0x7fa2612c, 0x22a9, 0x45e9, 0x9a, 0xf7, 0xc7, 0x41, 110, 0xff, 0xf7, 0xa5), Version(0x6020000)]
    internal interface IKeyTimeHelperStatics
    {
        KeyTime FromTimeSpan([In] TimeSpan timeSpan);
    }
}

