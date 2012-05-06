namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(IDataTemplateSelectorFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both), WebHostHidden, Version(0x6020000)]
    public class DataTemplateSelector : IDataTemplateSelector, IDataTemplateSelectorOverrides
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataTemplateSelector();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataTemplate SelectTemplate([In] object item, [In] DependencyObject container);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual DataTemplate SelectTemplateCore([In] object item, [In] DependencyObject container);
    }
}

