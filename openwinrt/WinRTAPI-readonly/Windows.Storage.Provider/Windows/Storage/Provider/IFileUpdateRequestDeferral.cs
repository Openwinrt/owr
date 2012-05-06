namespace Windows.Storage.Provider
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xffcedb2b, 0x8ade, 0x44a5, 0xbb, 0, 0x16, 0x4c, 0x4e, 0x72, 0xf1, 0x3a), ExclusiveTo(typeof(FileUpdateRequestDeferral)), Version(0x6020000)]
    internal interface IFileUpdateRequestDeferral
    {
        void Complete();
    }
}

