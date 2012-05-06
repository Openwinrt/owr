namespace Windows.Devices.Input
{
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Guid(0xf625aa5d, 0x2354, 0x4cc7, 0x92, 0x30, 150, 0x94, 0x1c, 150, 0x9f, 0xde), ExclusiveTo(typeof(MouseEventArgs))]
    internal interface IMouseEventArgs
    {
        Windows.Devices.Input.MouseDelta MouseDelta { get; }
    }
}

