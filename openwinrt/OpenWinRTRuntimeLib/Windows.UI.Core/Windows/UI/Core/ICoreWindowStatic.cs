namespace Windows.UI.Core
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(CoreWindow)), WebHostHidden, Guid(0xf5380075, 0x8d4e, 0x4e07, 0xb1, 40, 0xfd, 0x92, 0xe7, 0x3d, 0x7a, 0x7f)]
    internal interface ICoreWindowStatic
    {
        CoreWindow GetForCurrentThread();

        CoreWindow Current { get; }
    }
}

