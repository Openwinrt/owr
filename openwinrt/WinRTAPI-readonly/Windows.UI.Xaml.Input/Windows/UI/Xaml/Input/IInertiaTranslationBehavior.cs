namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x45d3a512, 0x3b32, 0x4882, 0xa4, 0xc2, 0xec, 250, 0x2d, 0x4b, 0x6d, 240), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(InertiaTranslationBehavior))]
    internal interface IInertiaTranslationBehavior
    {
        double DesiredDeceleration { get; [param: In] set; }

        double DesiredDisplacement { get; [param: In] set; }
    }
}

