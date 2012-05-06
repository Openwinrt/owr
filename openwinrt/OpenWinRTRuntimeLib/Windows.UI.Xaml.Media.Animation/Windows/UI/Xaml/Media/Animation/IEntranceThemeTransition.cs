namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(EntranceThemeTransition)), Windows.Foundation.Metadata.Guid(0x7698c09, 0xa8e3, 0x419a, 160, 0x1d, 0x74, 0x10, 160, 0xae, 0x8e, 200)]
    internal interface IEntranceThemeTransition
    {
        double FromHorizontalOffset { get; [param: In] set; }

        double FromVerticalOffset { get; [param: In] set; }

        bool IsStaggeringEnabled { get; [param: In] set; }
    }
}

