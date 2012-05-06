namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(ISetterBaseFactory), CompositionType.Protected, 0x6020000), WebHostHidden, Threading(ThreadingModel.Both)]
    public class SetterBase : DependencyObject, ISetterBase
    {
        public bool IsSealed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.ISetterBase.IsSealed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

