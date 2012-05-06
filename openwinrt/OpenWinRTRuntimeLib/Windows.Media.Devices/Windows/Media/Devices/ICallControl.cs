namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(CallControl)), Windows.Foundation.Metadata.Guid(0xa520d0d6, 0xae8d, 0x45db, 0x80, 0x11, 0xca, 0x49, 0xd3, 0xb3, 0xe5, 120)]
    internal interface ICallControl
    {
        event CallControlEventHandler AnswerRequested;

        event CallControlEventHandler AudioTransferRequested;

        event DialRequestedEventHandler DialRequested;

        event CallControlEventHandler HangUpRequested;

        event KeypadPressedEventHandler KeypadPressed;

        event RedialRequestedEventHandler RedialRequested;

        void EndCall([In] ulong callToken);
        void IndicateActiveCall([In] ulong callToken);
        ulong IndicateNewIncomingCall([In] bool enableRinger, [In] string callerId);
        ulong IndicateNewOutgoingCall();

        bool HasRinger { get; }
    }
}

