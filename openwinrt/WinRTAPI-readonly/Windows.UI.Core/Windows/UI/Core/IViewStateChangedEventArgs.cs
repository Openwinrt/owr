namespace Windows.UI.Core
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x574b41e9, 0x40bd, 0x41bf, 160, 160, 0x69, 0xc2, 0x6f, 7, 0xb9, 0xde), ExclusiveTo(typeof(ViewStateChangedEventArgs)), WebHostHidden, Version(0x6020000)]
    internal interface IViewStateChangedEventArgs : ICoreWindowEventArgs
    {
        uint ViewState { get; }
    }
}

