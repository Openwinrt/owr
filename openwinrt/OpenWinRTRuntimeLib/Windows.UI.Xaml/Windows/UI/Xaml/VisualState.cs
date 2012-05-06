namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Markup;
    using Windows.UI.Xaml.Media.Animation;

    [ContentProperty(Name="Storyboard"), MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), WebHostHidden, Threading(ThreadingModel.Both), Version(0x6020000)]
    public sealed class VisualState : DependencyObject, IVisualState
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public VisualState();

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Animation.Storyboard Storyboard { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.IVisualState.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.Media.Animation.Storyboard Windows.UI.Xaml.IVisualState.Storyboard { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

