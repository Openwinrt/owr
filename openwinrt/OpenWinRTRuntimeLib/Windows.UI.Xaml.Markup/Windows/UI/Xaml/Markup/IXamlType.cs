namespace Windows.UI.Xaml.Markup
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [Windows.Foundation.Metadata.Guid(0x7920eab1, 0xa2e5, 0x479a, 0xbd, 80, 0x6c, 0xef, 60, 11, 0x49, 0x70), WebHostHidden, Version(0x6020000)]
    public interface IXamlType
    {
        object ActivateInstance();
        void AddToMap([In] object instance, [In] object key, [In] object value);
        void AddToVector([In] object instance, [In] object value);
        object CreateFromString([In] string value);
        IXamlMember GetMember([In] string name);
        void RunInitializer();

        IXamlType BaseType { get; }

        IXamlMember ContentProperty { get; }

        string FullName { get; }

        bool IsArray { get; }

        bool IsBindable { get; }

        bool IsCollection { get; }

        bool IsConstructible { get; }

        bool IsDictionary { get; }

        bool IsMarkupExtension { get; }

        IXamlType ItemType { get; }

        IXamlType KeyType { get; }

        TypeName UnderlyingType { get; }
    }
}

