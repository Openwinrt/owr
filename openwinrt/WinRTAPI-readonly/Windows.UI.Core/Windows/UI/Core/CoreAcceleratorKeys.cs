namespace Windows.UI.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000)]
    public sealed class CoreAcceleratorKeys : ICoreAcceleratorKeys
    {
        public event TypedEventHandler<CoreDispatcher, AcceleratorKeyEventArgs> AcceleratorKeyActivated;

        public event TypedEventHandler<CoreDispatcher, AcceleratorKeyEventArgs> Windows.UI.Core.ICoreAcceleratorKeys.AcceleratorKeyActivated;
    }
}

