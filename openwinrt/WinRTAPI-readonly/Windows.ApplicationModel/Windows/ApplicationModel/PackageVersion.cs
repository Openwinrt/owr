namespace Windows.ApplicationModel
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct PackageVersion
    {
        public ushort Major;
        public ushort Minor;
        public ushort Build;
        public ushort Revision;
    }
}

