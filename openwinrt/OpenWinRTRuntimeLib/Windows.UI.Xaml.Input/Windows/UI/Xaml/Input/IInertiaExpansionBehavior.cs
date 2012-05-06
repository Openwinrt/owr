namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(InertiaExpansionBehavior)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x751d87e5, 0x8d42, 0x44c5, 150, 0x5e, 60, 0xd3, 12, 0xc9, 0xd6, 0xf7), Version(0x6020000)]
    internal interface IInertiaExpansionBehavior
    {
        double DesiredDeceleration { get; [param: In] set; }

        double DesiredExpansion { get; [param: In] set; }
    }
}

