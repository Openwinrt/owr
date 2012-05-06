namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(ToggleSwitch)), Windows.Foundation.Metadata.Guid(0xbfd07f53, 0xf8ca, 0x4e47, 0x94, 0x9e, 0x9e, 0x80, 0x42, 0x9b, 0x3d, 0x16)]
    internal interface IToggleSwitchOverrides
    {
        void OnHeaderChanged([In] object oldContent, [In] object newContent);
        void OnOffContentChanged([In] object oldContent, [In] object newContent);
        void OnOnContentChanged([In] object oldContent, [In] object newContent);
        void OnToggled();
    }
}

