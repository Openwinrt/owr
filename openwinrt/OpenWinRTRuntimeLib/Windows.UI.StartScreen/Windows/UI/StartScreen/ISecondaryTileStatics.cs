namespace Windows.UI.StartScreen
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(SecondaryTile)), Windows.Foundation.Metadata.Guid(0x99908dae, 0xd051, 0x4676, 0x87, 0xfe, 0x9e, 0xc2, 0x42, 0xd8, 60, 0x74)]
    internal interface ISecondaryTileStatics
    {
        bool Exists([In] string tileId);
        [DefaultOverload, Overload("FindAllAsync")]
        IAsyncOperation<IVectorView<SecondaryTile>> FindAllAsync();
        [Overload("FindAllForApplicationAsync"), DefaultOverload]
        IAsyncOperation<IVectorView<SecondaryTile>> FindAllAsync([In] string applicationId);
        IAsyncOperation<IVectorView<SecondaryTile>> FindAllForPackageAsync();
    }
}

