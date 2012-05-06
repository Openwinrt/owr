namespace Windows.UI.Xaml.Media.Imaging
{
    using System;
    using Windows.Foundation.Metadata;

    [Flags, WebHostHidden, Version(0x6020000)]
    public enum BitmapCreateOptions : uint
    {
        IgnoreImageCache = 8,
        None = 0
    }
}

