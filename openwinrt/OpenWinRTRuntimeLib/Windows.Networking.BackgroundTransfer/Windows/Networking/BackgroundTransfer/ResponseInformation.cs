namespace Windows.Networking.BackgroundTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ResponseInformation : IResponseInformation
    {
        public Uri ActualUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, string> Headers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsResumable { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint StatusCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Uri Windows.Networking.BackgroundTransfer.IResponseInformation.ActualUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IMapView<string, string> Windows.Networking.BackgroundTransfer.IResponseInformation.Headers { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Networking.BackgroundTransfer.IResponseInformation.IsResumable { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Networking.BackgroundTransfer.IResponseInformation.StatusCode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

