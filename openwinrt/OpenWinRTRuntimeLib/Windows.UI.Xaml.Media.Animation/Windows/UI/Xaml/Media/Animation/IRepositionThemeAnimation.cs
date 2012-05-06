namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(RepositionThemeAnimation)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xecda24e8, 0x8945, 0x4949, 0xa1, 0xbf, 0x62, 0x10, 0x99, 0x65, 0xa7, 0xe9), Version(0x6020000)]
    internal interface IRepositionThemeAnimation
    {
        double FromHorizontalOffset { get; [param: In] set; }

        double FromVerticalOffset { get; [param: In] set; }

        string TargetName { get; [param: In] set; }
    }
}

