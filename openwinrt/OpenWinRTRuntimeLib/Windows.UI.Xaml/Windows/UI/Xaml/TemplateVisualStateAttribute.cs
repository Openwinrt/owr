namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), AllowMultiple, Windows.Foundation.Metadata.AttributeUsage(Windows.Foundation.Metadata.AttributeTargets.RuntimeClass)]
    public sealed class TemplateVisualStateAttribute : Attribute
    {
        public string GroupName;
        public string Name;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public TemplateVisualStateAttribute();
    }
}

