namespace Windows.UI.Xaml.Automation
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden]
    public enum WindowInteractionState
    {
        Running,
        Closing,
        ReadyForUserInteraction,
        BlockedByModalWindow,
        NotResponding
    }
}

