namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;
    using Windows.UI.Xaml.Media.Animation;

    [Composable(typeof(IContentControlFactory), CompositionType.Public, 0x6020000), ContentProperty(Name="Content"), WebHostHidden, Version(0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IContentControlStatics), 0x6020000)]
    public class ContentControl : Control, IContentControl, IContentControlOverrides
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ContentControl();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnContentChanged([In] object oldContent, [In] object newContent);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnContentTemplateChanged([In] DataTemplate oldContentTemplate, [In] DataTemplate newContentTemplate);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnContentTemplateSelectorChanged([In] DataTemplateSelector oldContentTemplateSelector, [In] DataTemplateSelector newContentTemplateSelector);

        public object Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ContentProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataTemplate ContentTemplate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ContentTemplateProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataTemplateSelector ContentTemplateSelector { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ContentTemplateSelectorProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TransitionCollection ContentTransitions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ContentTransitionsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.UI.Xaml.Controls.IContentControl.Content { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public DataTemplate Windows.UI.Xaml.Controls.IContentControl.ContentTemplate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public DataTemplateSelector Windows.UI.Xaml.Controls.IContentControl.ContentTemplateSelector { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public TransitionCollection Windows.UI.Xaml.Controls.IContentControl.ContentTransitions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

