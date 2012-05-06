namespace Windows.ApplicationModel.Activation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Pickers.Provider;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class FileOpenPickerActivatedEventArgs : IFileOpenPickerActivatedEventArgs, IActivatedEventArgs
    {
        public Windows.Storage.Pickers.Provider.FileOpenPickerUI FileOpenPickerUI { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ActivationKind Kind { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ApplicationExecutionState PreviousExecutionState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.ApplicationModel.Activation.SplashScreen SplashScreen { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ActivationKind Windows.ApplicationModel.Activation.IActivatedEventArgs.Kind { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ApplicationExecutionState Windows.ApplicationModel.Activation.IActivatedEventArgs.PreviousExecutionState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.ApplicationModel.Activation.SplashScreen Windows.ApplicationModel.Activation.IActivatedEventArgs.SplashScreen { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.Pickers.Provider.FileOpenPickerUI Windows.ApplicationModel.Activation.IFileOpenPickerActivatedEventArgs.FileOpenPickerUI { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

