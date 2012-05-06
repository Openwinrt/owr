namespace Windows.Media.PlayTo
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x6f026d5c, 0xcf75, 0x4c2b, 0x91, 0x3e, 0x6d, 0x7c, 0x6c, 50, 0x91, 0x79), Version(0x6020000), ExclusiveTo(typeof(VolumeChangeRequestedEventArgs))]
    internal interface IVolumeChangeRequestedEventArgs
    {
        double Volume { get; }
    }
}

