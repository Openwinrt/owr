namespace Windows.ApplicationModel.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Core;

    [Version(0x6020000), WebHostHidden]
    public sealed class CoreApplicationView : ICoreApplicationView
    {
        public event TypedEventHandler<CoreApplicationView, IActivatedEventArgs> Activated;

        public event TypedEventHandler<CoreApplicationView, IActivatedEventArgs> Windows.ApplicationModel.Core.ICoreApplicationView.Activated;

        public Windows.UI.Core.CoreWindow CoreWindow { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsHosted { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsMain { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Core.CoreWindow Windows.ApplicationModel.Core.ICoreApplicationView.CoreWindow { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.ApplicationModel.Core.ICoreApplicationView.IsHosted { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.ApplicationModel.Core.ICoreApplicationView.IsMain { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

