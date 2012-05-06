namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation;

    [Windows.Foundation.Metadata.Guid(0x374bf581, 0x7716, 0x4bbc, 130, 0xeb, 0xd9, 0x97, 0, 110, 0xa9, 0x99), WebHostHidden, Version(0x6020000)]
    public interface IScrollProvider
    {
        void Scroll([In] ScrollAmount horizontalAmount, [In] ScrollAmount verticalAmount);
        void SetScrollPercent([In] double horizontalPercent, [In] double verticalPercent);

        bool HorizontallyScrollable { get; }

        double HorizontalScrollPercent { get; }

        double HorizontalViewSize { get; }

        bool VerticallyScrollable { get; }

        double VerticalScrollPercent { get; }

        double VerticalViewSize { get; }
    }
}

