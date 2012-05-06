namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IPropertyMetadataStatics), 0x6020000), WebHostHidden, Composable(typeof(IPropertyMetadataFactory), CompositionType.Public, 0x6020000)]
    public class PropertyMetadata : IPropertyMetadata
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PropertyMetadata([In] object defaultValue);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PropertyMetadata([In] object defaultValue, [In] PropertyChangedCallback propertyChangedCallback);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateWithDefaultValue"), DefaultOverload]
        public static PropertyMetadata Create([In] object defaultValue);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateWithFactory")]
        public static PropertyMetadata Create([In] Windows.UI.Xaml.CreateDefaultValueCallback createDefaultValueCallback);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateWithDefaultValueAndCallback"), DefaultOverload]
        public static PropertyMetadata Create([In] object defaultValue, [In] PropertyChangedCallback propertyChangedCallback);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateWithFactoryAndCallback")]
        public static PropertyMetadata Create([In] Windows.UI.Xaml.CreateDefaultValueCallback createDefaultValueCallback, [In] PropertyChangedCallback propertyChangedCallback);

        public Windows.UI.Xaml.CreateDefaultValueCallback CreateDefaultValueCallback { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object DefaultValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.CreateDefaultValueCallback Windows.UI.Xaml.IPropertyMetadata.CreateDefaultValueCallback { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.UI.Xaml.IPropertyMetadata.DefaultValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

