namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Markup;

    [ContentProperty(Name="Template"), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Composable(typeof(IFrameworkTemplateFactory), CompositionType.Protected, 0x6020000), WebHostHidden]
    public class FrameworkTemplate : DependencyObject, IFrameworkTemplate
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected FrameworkTemplate();
    }
}

