namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xe5af3542, 0xca67, 0x4081, 0x99, 0x5b, 0x70, 0x9d, 0xd1, 0x37, 0x92, 0xdf)]
    public interface ICommand
    {
        event Windows.Foundation.EventHandler<object> CanExecuteChanged;

        bool CanExecute([In] object parameter);
        void Execute([In] object parameter);
    }
}

