namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(ScrollEventArgs)), Guid(0xc57e5168, 0x3afe, 0x448d, 0xb7, 0x52, 0x2f, 0x36, 0x4c, 0x75, 0xd7, 0x43), Version(0x6020000)]
    internal interface IScrollEventArgs
    {
        double NewValue { get; }

        Windows.UI.Xaml.Controls.Primitives.ScrollEventType ScrollEventType { get; }
    }
}

