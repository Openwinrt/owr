namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(StackPanel)), Windows.Foundation.Metadata.Guid(0xb8ae8fe2, 0xd641, 0x4fd7, 0x80, 180, 0x74, 0x39, 0x20, 0x7d, 0x27, 0x98), WebHostHidden, Version(0x6020000)]
    internal interface IStackPanel
    {
        bool AreScrollSnapPointsRegular { get; [param: In] set; }

        Windows.UI.Xaml.Controls.Orientation Orientation { get; [param: In] set; }
    }
}

