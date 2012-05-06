namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [Activatable(0x6020000), Threading(ThreadingModel.Both), Activatable(typeof(IInputScopeNameFactory), 0x6020000), Version(0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), ContentProperty(Name="NameValue")]
    public sealed class InputScopeName : DependencyObject, IInputScopeName
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public InputScopeName();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public InputScopeName([In] InputScopeNameValue nameValue);

        public InputScopeNameValue NameValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public InputScopeNameValue Windows.UI.Xaml.Input.IInputScopeName.NameValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

