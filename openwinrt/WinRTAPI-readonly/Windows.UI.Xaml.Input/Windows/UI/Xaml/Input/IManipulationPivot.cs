namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x2e3838a5, 0xe6c2, 0x4998, 130, 0xac, 0x18, 0x74, 0x8b, 20, 0x16, 0x66), WebHostHidden, ExclusiveTo(typeof(ManipulationPivot))]
    internal interface IManipulationPivot
    {
        Point Center { get; [param: In] set; }

        double Radius { get; [param: In] set; }
    }
}

