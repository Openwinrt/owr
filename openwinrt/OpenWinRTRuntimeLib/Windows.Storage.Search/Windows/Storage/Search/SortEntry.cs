namespace Windows.Storage.Search
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct SortEntry
    {
        public string PropertyName;
        public bool AscendingOrder;
    }
}

