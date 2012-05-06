namespace Windows.UI.WebUI
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.Background;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class WebUIBackgroundTaskInstanceRuntimeClass : IWebUIBackgroundTaskInstance, IBackgroundTaskInstance
    {
        public event BackgroundTaskCanceledEventHandler Canceled;

        public event BackgroundTaskCanceledEventHandler Windows.ApplicationModel.Background.IBackgroundTaskInstance.Canceled;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public BackgroundTaskDeferral GetDeferral();

        public Guid InstanceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Progress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Succeeded { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint SuspendedCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public BackgroundTaskRegistration Task { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object TriggerDetails { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Guid Windows.ApplicationModel.Background.IBackgroundTaskInstance.InstanceId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public uint Windows.ApplicationModel.Background.IBackgroundTaskInstance.Progress { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public uint Windows.ApplicationModel.Background.IBackgroundTaskInstance.SuspendedCount { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public BackgroundTaskRegistration Windows.ApplicationModel.Background.IBackgroundTaskInstance.Task { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public object Windows.ApplicationModel.Background.IBackgroundTaskInstance.TriggerDetails { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.WebUI.IWebUIBackgroundTaskInstance.Succeeded { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

