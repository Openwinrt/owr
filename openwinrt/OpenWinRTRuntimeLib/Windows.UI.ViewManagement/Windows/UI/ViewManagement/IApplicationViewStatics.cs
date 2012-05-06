namespace Windows.UI.ViewManagement
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x2614e85e, 0xde8, 0x426c, 170, 0x86, 0xf6, 0xee, 13, 0x1a, 10, 0x5c), ExclusiveTo(typeof(ApplicationView)), Version(0x6020000)]
    internal interface IApplicationViewStatics
    {
        ApplicationView GetForCurrentView();
        bool TryUnsnap();

        ApplicationViewState Value { get; }
    }
}

