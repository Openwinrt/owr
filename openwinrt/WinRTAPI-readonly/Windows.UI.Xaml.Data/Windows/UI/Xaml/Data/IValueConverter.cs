namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xe6f2fef0, 0x712, 0x487f, 0xb3, 0x13, 0xf3, 0, 0xb8, 0xd7, 0x9a, 0xa1), WebHostHidden]
    public interface IValueConverter
    {
        object Convert([In] object value, [In] TypeName targetType, [In] object parameter, [In] string language);
        object ConvertBack([In] object value, [In] TypeName targetType, [In] object parameter, [In] string language);
    }
}

