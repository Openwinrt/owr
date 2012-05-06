namespace Windows.Foundation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(typeof(IUriRuntimeClassFactory), 0x6020000), Threading(ThreadingModel.Both), DualApiPartition(version=0x6020000), Version(0x6020000)]
    public sealed class Uri : IUriRuntimeClass
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Uri([In] string uri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Uri([In] string baseUri, [In] string relativeUri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Uri CombineUri([In] string relativeUri);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool Equals([In] Uri pUri);

        public string AbsoluteUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string DisplayUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Domain { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Extension { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Fragment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Host { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Password { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Path { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Port { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Query { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string RawUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string SchemeName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Suspicious { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string UserName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Foundation.IUriRuntimeClass.AbsoluteUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Foundation.IUriRuntimeClass.DisplayUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Foundation.IUriRuntimeClass.Domain { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Foundation.IUriRuntimeClass.Extension { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Foundation.IUriRuntimeClass.Fragment { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Foundation.IUriRuntimeClass.Host { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Foundation.IUriRuntimeClass.Password { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Foundation.IUriRuntimeClass.Path { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public int Windows.Foundation.IUriRuntimeClass.Port { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Foundation.IUriRuntimeClass.Query { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Foundation.IUriRuntimeClass.RawUri { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Foundation.IUriRuntimeClass.SchemeName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Foundation.IUriRuntimeClass.Suspicious { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Foundation.IUriRuntimeClass.UserName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

