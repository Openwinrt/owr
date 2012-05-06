namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x84c1daa7, 0x7272, 0x4463, 0xb6, 0xc3, 0xa4, 11, 0x9b, 0xa1, 0x51, 0xfc), ExclusiveTo(typeof(ManipulationStartedRoutedEventArgs)), Version(0x6020000)]
    internal interface IManipulationStartedRoutedEventArgsFactory
    {
        ManipulationStartedRoutedEventArgs CreateInstance([In] object outer, out object inner);
    }
}

