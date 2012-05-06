namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(TranslateTransform)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xc975905c, 0x3c36, 0x4229, 0x81, 0x7b, 0x17, 0x8f, 100, 0xc0, 0xe1, 0x13)]
    internal interface ITranslateTransform
    {
        double X { get; [param: In] set; }

        double Y { get; [param: In] set; }
    }
}

