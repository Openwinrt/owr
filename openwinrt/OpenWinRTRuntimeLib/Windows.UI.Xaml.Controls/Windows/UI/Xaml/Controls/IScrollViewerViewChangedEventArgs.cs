namespace Windows.UI.Xaml.Controls
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(ScrollViewerViewChangedEventArgs)), Guid(0x4dd04f7e, 0x7a11, 0x4b2e, 0x99, 0x33, 0x57, 0x7d, 0xf3, 0x92, 0x52, 0xb6)]
    internal interface IScrollViewerViewChangedEventArgs
    {
        bool IsIntermediate { get; }
    }
}

