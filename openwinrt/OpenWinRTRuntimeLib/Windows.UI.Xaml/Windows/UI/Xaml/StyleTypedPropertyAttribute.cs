namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, AllowMultiple, Windows.Foundation.Metadata.AttributeUsage(Windows.Foundation.Metadata.AttributeTargets.RuntimeClass), Version(0x6020000)]
    public sealed class StyleTypedPropertyAttribute : Attribute
    {
        public string Property;
        public Type StyleTargetType;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public StyleTypedPropertyAttribute();
    }
}

