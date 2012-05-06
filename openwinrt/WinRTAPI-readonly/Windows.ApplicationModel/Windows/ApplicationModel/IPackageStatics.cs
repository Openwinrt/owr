namespace Windows.ApplicationModel
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x4e534bdf, 0x2960, 0x4878, 0x97, 0xa4, 150, 0x24, 0xde, 0xb7, 0x2f, 0x2d), ExclusiveTo(typeof(Package))]
    internal interface IPackageStatics
    {
        Package Current { get; }
    }
}

