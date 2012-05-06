namespace Windows.UI.Xaml.Data
{
    using System;
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(PropertyChangedEventArgs)), Version(0x6020000), Guid(0x4f33a9a0, 0x5cf4, 0x47a4, 0xb1, 0x6f, 0xd7, 250, 0xaf, 0x17, 0x45, 0x7e)]
    internal interface IPropertyChangedEventArgs
    {
        string PropertyName { get; }
    }
}

