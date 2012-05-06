namespace Windows.UI.ViewManagement
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ApplicationViewStateChangedEventArgs : IApplicationViewStateChangedEventArgs
    {
        public ApplicationViewState ViewState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ApplicationViewState Windows.UI.ViewManagement.IApplicationViewStateChangedEventArgs.ViewState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

