namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;
    using Windows.UI.Xaml.Markup;

    [Threading(ThreadingModel.Both), ContentProperty(Name="Header"), Version(0x6020000), Activatable(0x6020000), Static(typeof(IToggleSwitchStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden]
    public sealed class ToggleSwitch : Control, IToggleSwitch, IToggleSwitchOverrides
    {
        public event RoutedEventHandler Toggled;

        public event RoutedEventHandler Windows.UI.Xaml.Controls.IToggleSwitch.Toggled;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ToggleSwitch();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnHeaderChanged([In] object oldContent, [In] object newContent);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnOffContentChanged([In] object oldContent, [In] object newContent);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnOnContentChanged([In] object oldContent, [In] object newContent);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnToggled();

        public object Header { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty HeaderProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataTemplate HeaderTemplate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty HeaderTemplateProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsOn { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsOnProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object OffContent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty OffContentProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataTemplate OffContentTemplate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty OffContentTemplateProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object OnContent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty OnContentProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataTemplate OnContentTemplate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty OnContentTemplateProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ToggleSwitchTemplateSettings TemplateSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.UI.Xaml.Controls.IToggleSwitch.Header { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public DataTemplate Windows.UI.Xaml.Controls.IToggleSwitch.HeaderTemplate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IToggleSwitch.IsOn { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object Windows.UI.Xaml.Controls.IToggleSwitch.OffContent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public DataTemplate Windows.UI.Xaml.Controls.IToggleSwitch.OffContentTemplate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object Windows.UI.Xaml.Controls.IToggleSwitch.OnContent { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public DataTemplate Windows.UI.Xaml.Controls.IToggleSwitch.OnContentTemplate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ToggleSwitchTemplateSettings Windows.UI.Xaml.Controls.IToggleSwitch.TemplateSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

