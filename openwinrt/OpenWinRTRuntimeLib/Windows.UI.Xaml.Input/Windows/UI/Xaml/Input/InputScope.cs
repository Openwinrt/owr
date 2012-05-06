namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Activatable(0x6020000)]
    public sealed class InputScope : DependencyObject, IInputScope
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public InputScope();

        public IVector<InputScopeName> Names { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<InputScopeName> Windows.UI.Xaml.Input.IInputScope.Names { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

