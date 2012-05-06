namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Windows.Foundation.Metadata.Guid(0x2b9aa11, 0xb47, 0x4e7d, 0xad, 0x91, 0x3a, 0x41, 0x68, 0xed, 0x23, 13), ExclusiveTo(typeof(PasswordBox)), Version(0x6020000), WebHostHidden]
    internal interface IPasswordBox
    {
        event ContextMenuOpeningEventHandler ContextMenuOpening;

        event RoutedEventHandler PasswordChanged;

        void SelectAll();

        bool IsPasswordRevealButtonEnabled { get; [param: In] set; }

        int MaxLength { get; [param: In] set; }

        string Password { get; [param: In] set; }

        string PasswordChar { get; [param: In] set; }
    }
}

