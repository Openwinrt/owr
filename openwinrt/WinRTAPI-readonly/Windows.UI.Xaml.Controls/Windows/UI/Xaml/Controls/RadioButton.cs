namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [WebHostHidden, Threading(ThreadingModel.Both), Static(typeof(IRadioButtonStatics), 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(IRadioButtonFactory), CompositionType.Public, 0x6020000), Version(0x6020000)]
    public class RadioButton : ToggleButton, IRadioButton
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public RadioButton();

        public string GroupName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty GroupNameProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Xaml.Controls.IRadioButton.GroupName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

