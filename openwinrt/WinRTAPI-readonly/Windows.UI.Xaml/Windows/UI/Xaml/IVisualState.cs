namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Media.Animation;

    [ExclusiveTo(typeof(VisualState)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x6320affc, 0xc31a, 0x4450, 0xaf, 0xde, 0xf6, 0xea, 0x7b, 0xd1, 0xf5, 0x86), Version(0x6020000)]
    internal interface IVisualState
    {
        string Name { get; }

        Windows.UI.Xaml.Media.Animation.Storyboard Storyboard { get; [param: In] set; }
    }
}

