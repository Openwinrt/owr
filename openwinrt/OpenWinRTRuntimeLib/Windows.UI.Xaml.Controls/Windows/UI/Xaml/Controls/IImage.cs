namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Media.PlayTo;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;

    [ExclusiveTo(typeof(Image)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x495b7402, 0x9af3, 0x4e50, 170, 0x90, 3, 0x38, 0x8f, 0x30, 0x86, 210)]
    internal interface IImage
    {
        event ExceptionRoutedEventHandler ImageFailed;

        event RoutedEventHandler ImageOpened;

        Thickness NineGrid { get; [param: In] set; }

        Windows.Media.PlayTo.PlayToSource PlayToSource { get; }

        ImageSource Source { get; [param: In] set; }

        Windows.UI.Xaml.Media.Stretch Stretch { get; [param: In] set; }
    }
}

