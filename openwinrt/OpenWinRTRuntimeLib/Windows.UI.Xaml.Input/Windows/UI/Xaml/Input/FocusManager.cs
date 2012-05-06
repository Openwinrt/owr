namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Static(typeof(IFocusManagerStatics), 0x6020000), Version(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class FocusManager : IFocusManager
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object GetFocusedElement();
    }
}

