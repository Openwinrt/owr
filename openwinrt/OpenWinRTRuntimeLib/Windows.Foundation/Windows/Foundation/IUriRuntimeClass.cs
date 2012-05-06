namespace Windows.Foundation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Uri)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x8d184e6e, 0xfc32, 0x45c9, 0xa9, 0x8f, 0x86, 0xe2, 0x56, 0x88, 0xc6, 0x60)]
    internal interface IUriRuntimeClass
    {
        Uri CombineUri([In] string relativeUri);
        bool Equals([In] Uri pUri);

        string AbsoluteUri { get; }

        string DisplayUri { get; }

        string Domain { get; }

        string Extension { get; }

        string Fragment { get; }

        string Host { get; }

        string Password { get; }

        string Path { get; }

        int Port { get; }

        string Query { get; }

        string RawUri { get; }

        string SchemeName { get; }

        bool Suspicious { get; }

        string UserName { get; }
    }
}

