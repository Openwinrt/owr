namespace Windows.UI.WebUI
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.ApplicationModel.Activation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Pickers.Provider;

    [Version(0x6020000)]
    public sealed class WebUIFileSavePickerActivatedEventArgs : IFileSavePickerActivatedEventArgs, IActivatedEventArgs, IActivatedEventArgsDeferral
    {
        public Windows.UI.WebUI.ActivatedOperation ActivatedOperation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.Pickers.Provider.FileSavePickerUI FileSavePickerUI { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ActivationKind Kind { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ApplicationExecutionState PreviousExecutionState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.ApplicationModel.Activation.SplashScreen SplashScreen { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ActivationKind Windows.ApplicationModel.Activation.IActivatedEventArgs.Kind { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ApplicationExecutionState Windows.ApplicationModel.Activation.IActivatedEventArgs.PreviousExecutionState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.ApplicationModel.Activation.SplashScreen Windows.ApplicationModel.Activation.IActivatedEventArgs.SplashScreen { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Storage.Pickers.Provider.FileSavePickerUI Windows.ApplicationModel.Activation.IFileSavePickerActivatedEventArgs.FileSavePickerUI { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.WebUI.ActivatedOperation Windows.UI.WebUI.IActivatedEventArgsDeferral.ActivatedOperation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

