namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.MTA), Version(0x6020000), Static(typeof(IBackgroundTaskRegistrationStatics), 0x6020000)]
    public sealed class BackgroundTaskRegistration : IBackgroundTaskRegistration
    {
        public event BackgroundTaskCompletedEventHandler Completed;

        public event BackgroundTaskProgressEventHandler Progress;

        public event BackgroundTaskCompletedEventHandler Windows.ApplicationModel.Background.IBackgroundTaskRegistration.Completed;

        public event BackgroundTaskProgressEventHandler Windows.ApplicationModel.Background.IBackgroundTaskRegistration.Progress;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Unregister([In] bool cancelTask);

        public static IMapView<Guid, IBackgroundTaskRegistration> AllTasks { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Guid TaskId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Background.IBackgroundTaskRegistration.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Guid Windows.ApplicationModel.Background.IBackgroundTaskRegistration.TaskId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

