namespace Windows.Networking.BackgroundTransfer
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xf8bb9a12, 0xf713, 0x4792, 0x8b, 0x68, 0xd9, 210, 0x97, 0xf9, 0x1d, 0x2e), ExclusiveTo(typeof(ResponseInformation))]
    internal interface IResponseInformation
    {
        Uri ActualUri { get; }

        IMapView<string, string> Headers { get; }

        bool IsResumable { get; }

        uint StatusCode { get; }
    }
}

