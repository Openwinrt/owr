namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x2086b7a7, 0xac0e, 0x47d1, 0xab, 0x9b, 0x2a, 100, 0x29, 0x2a, 0xfd, 0xf8), WebHostHidden, Version(0x6020000)]
    public interface IValueProvider
    {
        void SetValue([In] string value);

        bool IsReadOnly { get; }

        string Value { get; }
    }
}

