namespace Windows.Media.Protection
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xb1de0ea6, 0x2094, 0x478d, 0x87, 0xa4, 0x8b, 0x95, 0x20, 15, 0x85, 0xc6)]
    public interface IMediaProtectionServiceRequest
    {
        Guid ProtectionSystem { get; }

        Guid Type { get; }
    }
}

