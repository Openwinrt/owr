namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Windows.Foundation.Metadata.Guid(0x3f7a0c6b, 0xd00f, 0x4730, 140, 0x1d, 0x48, 0xe1, 0x6c, 70, 0xf9, 0xca), Version(0x6020000), ExclusiveTo(typeof(Binding)), WebHostHidden]
    internal interface IBinding
    {
        IValueConverter Converter { get; [param: In] set; }

        string ConverterLanguage { get; [param: In] set; }

        object ConverterParameter { get; [param: In] set; }

        string ElementName { get; [param: In] set; }

        BindingMode Mode { get; [param: In] set; }

        PropertyPath Path { get; [param: In] set; }

        Windows.UI.Xaml.Data.RelativeSource RelativeSource { get; [param: In] set; }

        object Source { get; [param: In] set; }
    }
}

