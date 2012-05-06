namespace Windows.Storage
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class SetVersionRequest : ISetVersionRequest
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SetVersionDeferral GetDeferral();

        public uint CurrentVersion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint DesiredVersion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Storage.ISetVersionRequest.CurrentVersion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.Storage.ISetVersionRequest.DesiredVersion { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

