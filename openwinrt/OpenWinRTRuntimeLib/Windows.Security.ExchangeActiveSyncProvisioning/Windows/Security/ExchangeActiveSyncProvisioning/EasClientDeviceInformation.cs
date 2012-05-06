namespace Windows.Security.ExchangeActiveSyncProvisioning
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Activatable(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class EasClientDeviceInformation : IEasClientDeviceInformation
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public EasClientDeviceInformation();

        public string FriendlyName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Guid Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string OperatingSystem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string SystemManufacturer { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string SystemProductName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string SystemSku { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.ExchangeActiveSyncProvisioning.IEasClientDeviceInformation.FriendlyName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Guid Windows.Security.ExchangeActiveSyncProvisioning.IEasClientDeviceInformation.Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.ExchangeActiveSyncProvisioning.IEasClientDeviceInformation.OperatingSystem { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.ExchangeActiveSyncProvisioning.IEasClientDeviceInformation.SystemManufacturer { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.ExchangeActiveSyncProvisioning.IEasClientDeviceInformation.SystemProductName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Security.ExchangeActiveSyncProvisioning.IEasClientDeviceInformation.SystemSku { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

