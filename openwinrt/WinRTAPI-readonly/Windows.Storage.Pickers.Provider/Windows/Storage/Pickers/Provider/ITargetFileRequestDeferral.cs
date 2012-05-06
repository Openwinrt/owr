namespace Windows.Storage.Pickers.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x4aee9d91, 0xbf15, 0x4da9, 0x95, 0xf6, 0xf6, 0xb7, 0xd5, 0x58, 0x22, 0x5b), ExclusiveTo(typeof(TargetFileRequestDeferral)), Version(0x6020000)]
    internal interface ITargetFileRequestDeferral
    {
        void Complete();
    }
}

