namespace Windows.ApplicationModel.Activation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Devices.Printers.Extensions;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class PrintTaskSettingsActivatedEventArgs : IPrintTaskSettingsActivatedEventArgs, IActivatedEventArgs
    {
        public PrintTaskConfiguration Configuration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ActivationKind Kind { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ApplicationExecutionState PreviousExecutionState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.ApplicationModel.Activation.SplashScreen SplashScreen { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ActivationKind Windows.ApplicationModel.Activation.IActivatedEventArgs.Kind { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ApplicationExecutionState Windows.ApplicationModel.Activation.IActivatedEventArgs.PreviousExecutionState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.ApplicationModel.Activation.SplashScreen Windows.ApplicationModel.Activation.IActivatedEventArgs.SplashScreen { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PrintTaskConfiguration Windows.ApplicationModel.Activation.IPrintTaskSettingsActivatedEventArgs.Configuration { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

