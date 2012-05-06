namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Windows.Foundation.Metadata.Guid(0xd82f07d8, 0x73d5, 0x4379, 0xbd, 0x48, 0x7e, 5, 0x18, 0x4a, 0x8b, 0xad), WebHostHidden, ExclusiveTo(typeof(Storyboard)), Version(0x6020000)]
    internal interface IStoryboardStatics
    {
        string GetTargetName([In] Timeline element);
        string GetTargetProperty([In] Timeline element);
        void SetTarget([In] Timeline timeline, [In] DependencyObject target);
        void SetTargetName([In] Timeline element, [In] string name);
        void SetTargetProperty([In] Timeline element, [In] string path);

        DependencyProperty TargetNameProperty { get; }

        DependencyProperty TargetPropertyProperty { get; }
    }
}

