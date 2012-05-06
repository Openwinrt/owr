namespace Windows.UI.Xaml
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(PropertyPath)), Guid(0x300e5d8a, 0x1ff3, 0x4d2c, 0x95, 0xec, 0x27, 0xf8, 0x1d, 0xeb, 0xac, 0xb8), Version(0x6020000)]
    internal interface IPropertyPath
    {
        string Path { get; }
    }
}

