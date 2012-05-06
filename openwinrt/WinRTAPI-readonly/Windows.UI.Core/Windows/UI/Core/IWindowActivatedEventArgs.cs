namespace Windows.UI.Core
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(WindowActivatedEventArgs)), Guid(0x179d65e7, 0x4658, 0x4cb6, 170, 0x13, 0x41, 0xd0, 0x94, 0xea, 0x25, 0x5e)]
    internal interface IWindowActivatedEventArgs : ICoreWindowEventArgs
    {
        CoreWindowActivationState WindowActivationState { get; }
    }
}

