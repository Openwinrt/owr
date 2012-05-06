namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Activatable(typeof(INetworkOperatorNotificationTriggerFactory), 0x6020000), Threading(ThreadingModel.Both)]
    public sealed class NetworkOperatorNotificationTrigger : INetworkOperatorNotificationTrigger, IBackgroundTrigger
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public NetworkOperatorNotificationTrigger([In] string networkAccountId);

        public string NetworkAccountId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Background.INetworkOperatorNotificationTrigger.NetworkAccountId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

