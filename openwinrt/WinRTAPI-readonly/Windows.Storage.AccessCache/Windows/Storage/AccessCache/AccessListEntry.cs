namespace Windows.Storage.AccessCache
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct AccessListEntry
    {
        public string Token;
        public string Metadata;
    }
}

