namespace Windows.UI.Xaml
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ExceptionRoutedEventArgs)), Guid(0xdd9ff16a, 0x4b62, 0x4a6c, 0xa4, 0x9d, 6, 0x71, 0xef, 0x61, 0x36, 190), WebHostHidden, Version(0x6020000)]
    internal interface IExceptionRoutedEventArgs
    {
        string ErrorMessage { get; }
    }
}

