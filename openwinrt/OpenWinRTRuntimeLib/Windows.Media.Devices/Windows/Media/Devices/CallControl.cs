namespace Windows.Media.Devices
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Threading(ThreadingModel.Both), DualApiPartition(version=0x6020000), Static(typeof(ICallControlStatics), 0x6020000)]
    public sealed class CallControl : ICallControl
    {
        public event CallControlEventHandler AnswerRequested;

        public event CallControlEventHandler AudioTransferRequested;

        public event DialRequestedEventHandler DialRequested;

        public event CallControlEventHandler HangUpRequested;

        public event KeypadPressedEventHandler KeypadPressed;

        public event RedialRequestedEventHandler RedialRequested;

        public event CallControlEventHandler Windows.Media.Devices.ICallControl.AnswerRequested;

        public event CallControlEventHandler Windows.Media.Devices.ICallControl.AudioTransferRequested;

        public event DialRequestedEventHandler Windows.Media.Devices.ICallControl.DialRequested;

        public event CallControlEventHandler Windows.Media.Devices.ICallControl.HangUpRequested;

        public event KeypadPressedEventHandler Windows.Media.Devices.ICallControl.KeypadPressed;

        public event RedialRequestedEventHandler Windows.Media.Devices.ICallControl.RedialRequested;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void EndCall([In] ulong callToken);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static CallControl FromId([In] string deviceInterfaceId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static CallControl GetDefault();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void IndicateActiveCall([In] ulong callToken);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ulong IndicateNewIncomingCall([In] bool enableRinger, [In] string callerId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ulong IndicateNewOutgoingCall();

        public bool HasRinger { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Media.Devices.ICallControl.HasRinger { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

