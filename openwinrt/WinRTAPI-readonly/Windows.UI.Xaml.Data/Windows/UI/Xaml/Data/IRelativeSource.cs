namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(RelativeSource)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x2397ce84, 0x2822, 0x483a, 180, 0x99, 0xd0, 240, 0x31, 0xe0, 0x6c, 0x6b)]
    internal interface IRelativeSource
    {
        RelativeSourceMode Mode { get; [param: In] set; }
    }
}

