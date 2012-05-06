namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Composable(typeof(IDataTemplateFactory), CompositionType.Public, 0x6020000)]
    public class DataTemplate : FrameworkTemplate, IDataTemplate
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataTemplate();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DependencyObject LoadContent();
    }
}

