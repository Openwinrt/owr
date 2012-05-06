namespace Windows.ApplicationModel.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(CoreApplication)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xcf86461d, 0x261e, 0x4b72, 0x9a, 0xcd, 0x44, 0xed, 0x2a, 0xce, 0x6a, 0x29)]
    internal interface ICoreApplicationExit
    {
        event Windows.Foundation.EventHandler<object> Exiting;

        void Exit();
    }
}

