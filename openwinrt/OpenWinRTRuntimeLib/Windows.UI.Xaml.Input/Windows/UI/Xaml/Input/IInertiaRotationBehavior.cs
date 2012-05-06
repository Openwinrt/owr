namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x424cfb2e, 0xbbfd, 0x4625, 0xae, 120, 0x20, 0xc6, 0x5b, 0xf1, 0xef, 0xaf), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(InertiaRotationBehavior))]
    internal interface IInertiaRotationBehavior
    {
        double DesiredDeceleration { get; [param: In] set; }

        double DesiredRotation { get; [param: In] set; }
    }
}

