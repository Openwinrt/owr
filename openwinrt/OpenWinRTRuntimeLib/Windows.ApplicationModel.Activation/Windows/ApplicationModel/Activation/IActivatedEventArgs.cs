namespace Windows.ApplicationModel.Activation
{
    using Windows.Foundation.Metadata;

    [Guid(0xcf651713, 0xcd08, 0x4fd8, 0xb6, 0x97, 0xa2, 0x81, 0xb6, 0x54, 0x4e, 0x2e), Version(0x6020000)]
    public interface IActivatedEventArgs
    {
        ActivationKind Kind { get; }

        ApplicationExecutionState PreviousExecutionState { get; }

        Windows.ApplicationModel.Activation.SplashScreen SplashScreen { get; }
    }
}

