namespace Windows.ApplicationModel.Activation
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum ApplicationExecutionState
    {
        NotRunning,
        Running,
        Suspended,
        Terminated,
        ClosedByUser
    }
}

