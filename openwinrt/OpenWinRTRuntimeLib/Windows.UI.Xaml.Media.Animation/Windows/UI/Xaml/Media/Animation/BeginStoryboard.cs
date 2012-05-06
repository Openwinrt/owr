namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [ContentProperty(Name="Storyboard"), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Static(typeof(IBeginStoryboardStatics), 0x6020000), Activatable(0x6020000), Version(0x6020000)]
    public sealed class BeginStoryboard : TriggerAction, IBeginStoryboard
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public BeginStoryboard();

        public Windows.UI.Xaml.Media.Animation.Storyboard Storyboard { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty StoryboardProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Animation.Storyboard Windows.UI.Xaml.Media.Animation.IBeginStoryboard.Storyboard { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

