namespace Windows.UI.Xaml
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(MediaFailedRoutedEventArgs)), Guid(0x46d1fa8d, 0x5149, 0x4153, 0xba, 60, 0xb0, 0x3e, 100, 0xee, 0x53, 30), Version(0x6020000), WebHostHidden]
    internal interface IMediaFailedRoutedEventArgs
    {
        string ErrorTrace { get; }
    }
}

