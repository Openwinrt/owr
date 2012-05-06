namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.AttributeUsage(Windows.Foundation.Metadata.AttributeTargets.RuntimeClass), AllowMultiple]
    public sealed class TemplatePartAttribute : Attribute
    {
        public string Name;
        public System.Type Type;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public TemplatePartAttribute();
    }
}

