namespace Windows.Management.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.Storage;

    [Threading(ThreadingModel.MTA), Static(typeof(IApplicationDataManagerStatics), 0x6020000), Version(0x6020000)]
    public sealed class ApplicationDataManager : IApplicationDataManager
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ApplicationData CreateForPackageFamily([In] string packageFamilyName);
    }
}

