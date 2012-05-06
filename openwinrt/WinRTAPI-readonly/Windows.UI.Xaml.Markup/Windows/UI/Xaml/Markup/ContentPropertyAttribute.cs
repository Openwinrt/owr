namespace Windows.UI.Xaml.Markup
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.AttributeUsage(Windows.Foundation.Metadata.AttributeTargets.RuntimeClass)]
    public sealed class ContentPropertyAttribute : Attribute
    {
        public string Name;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ContentPropertyAttribute();
    }
}

