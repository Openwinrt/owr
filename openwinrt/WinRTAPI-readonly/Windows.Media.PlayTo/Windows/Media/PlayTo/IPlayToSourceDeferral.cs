namespace Windows.Media.PlayTo
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x4100891d, 0x278e, 0x4f29, 0x85, 0x9b, 0xa9, 0xe5, 1, 5, 0x3e, 0x7d), ExclusiveTo(typeof(PlayToSourceDeferral))]
    internal interface IPlayToSourceDeferral
    {
        void Complete();
    }
}

