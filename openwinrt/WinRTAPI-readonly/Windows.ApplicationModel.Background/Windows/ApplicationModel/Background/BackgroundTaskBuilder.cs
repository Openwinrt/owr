namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Threading(ThreadingModel.MTA), Activatable(0x6020000)]
    public sealed class BackgroundTaskBuilder : IBackgroundTaskBuilder
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public BackgroundTaskBuilder();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void AddCondition([In] IBackgroundCondition condition);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public BackgroundTaskRegistration Register();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetTrigger([In] IBackgroundTrigger trigger);

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string TaskEntryPoint { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.ApplicationModel.Background.IBackgroundTaskBuilder.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.ApplicationModel.Background.IBackgroundTaskBuilder.TaskEntryPoint { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

