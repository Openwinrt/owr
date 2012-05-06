namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Version(0x6020000), ExclusiveTo(typeof(VisualStateChangedEventArgs)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xfe216ab1, 0xf31f, 0x4791, 0x89, 0x89, 0xc7, 14, 0x1d, 0x9b, 0x59, 0xff)]
    internal interface IVisualStateChangedEventArgs
    {
        Windows.UI.Xaml.Controls.Control Control { get; [param: In] set; }

        VisualState NewState { get; [param: In] set; }

        VisualState OldState { get; [param: In] set; }
    }
}

