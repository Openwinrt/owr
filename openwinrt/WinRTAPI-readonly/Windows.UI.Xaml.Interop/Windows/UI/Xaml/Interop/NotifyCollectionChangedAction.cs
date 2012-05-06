namespace Windows.UI.Xaml.Interop
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden]
    public enum NotifyCollectionChangedAction
    {
        Add,
        Remove,
        Replace,
        Move,
        Reset
    }
}

