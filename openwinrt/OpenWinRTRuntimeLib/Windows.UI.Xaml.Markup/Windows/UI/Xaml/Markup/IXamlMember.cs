namespace Windows.UI.Xaml.Markup
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xc541f58c, 0x43a9, 0x4216, 0xb7, 0x18, 0xe0, 0xb1, 0x1b, 20, 0xe9, 0x3e)]
    public interface IXamlMember
    {
        object GetValue([In] object instance);
        void SetValue([In] object instance, [In] object value);

        bool IsAttachable { get; }

        bool IsDependencyProperty { get; }

        bool IsReadOnly { get; }

        string Name { get; }

        IXamlType TargetType { get; }

        IXamlType Type { get; }
    }
}

