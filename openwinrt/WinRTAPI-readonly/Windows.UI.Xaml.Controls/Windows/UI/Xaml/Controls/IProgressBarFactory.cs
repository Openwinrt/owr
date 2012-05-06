namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xda9a8c11, 0x1591, 0x400b, 0xa9, 0x93, 15, 0x1c, 0x5c, 0xc1, 0x2f, 0x3b), ExclusiveTo(typeof(ProgressBar)), WebHostHidden, Version(0x6020000)]
    internal interface IProgressBarFactory
    {
        ProgressBar CreateInstance([In] object outer, out object inner);
    }
}

