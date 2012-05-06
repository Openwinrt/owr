namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xcf75d69c, 0xf2f4, 0x486b, 0xb3, 2, 0xbb, 0x4c, 9, 0xba, 0xeb, 250)]
    public interface INotifyPropertyChanged
    {
        event PropertyChangedEventHandler PropertyChanged;
    }
}

