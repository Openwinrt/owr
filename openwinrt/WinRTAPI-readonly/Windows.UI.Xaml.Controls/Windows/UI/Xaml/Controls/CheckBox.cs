namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Composable(typeof(ICheckBoxFactory), CompositionType.Public, 0x6020000), WebHostHidden, Version(0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class CheckBox : ToggleButton, ICheckBox
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CheckBox();
    }
}

