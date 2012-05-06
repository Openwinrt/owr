namespace Windows.UI.Xaml.Controls
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Guid(0xaf0e05f7, 0xc4b7, 0x44c5, 0xb0, 0x9d, 0x5c, 0xb7, 5, 0x2b, 0x3a, 0x97), ExclusiveTo(typeof(NotifyEventArgs))]
    internal interface INotifyEventArgs
    {
        string Value { get; }
    }
}

