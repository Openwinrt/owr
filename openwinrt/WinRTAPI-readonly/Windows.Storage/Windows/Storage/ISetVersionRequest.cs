namespace Windows.Storage
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xb9c76b9b, 0x1056, 0x4e69, 0x83, 0x30, 0x16, 0x26, 0x19, 0x95, 0x6f, 0x9b), Version(0x6020000), ExclusiveTo(typeof(SetVersionRequest))]
    internal interface ISetVersionRequest
    {
        SetVersionDeferral GetDeferral();

        uint CurrentVersion { get; }

        uint DesiredVersion { get; }
    }
}

