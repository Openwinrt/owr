namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.Activation;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Composable(typeof(IApplicationFactory), CompositionType.Public, 0x6020000), Version(0x6020000), Static(typeof(IApplicationStatics), 0x6020000)]
    public class Application : IApplication, IApplicationOverrides
    {
        public event Windows.Foundation.EventHandler<object> Resuming;

        public event SuspendingEventHandler Suspending;

        public event Windows.UI.Xaml.UnhandledExceptionEventHandler UnhandledException;

        public event Windows.Foundation.EventHandler<object> Windows.UI.Xaml.IApplication.Resuming;

        public event SuspendingEventHandler Windows.UI.Xaml.IApplication.Suspending;

        public event Windows.UI.Xaml.UnhandledExceptionEventHandler Windows.UI.Xaml.IApplication.UnhandledException;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Application();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Exit();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("LoadComponent")]
        public static void LoadComponent([In] object component, [In] Uri resourceLocator);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("LoadComponentWithResourceLocation")]
        public static void LoadComponent([In] object component, [In] Uri resourceLocator, [In] ComponentResourceLocation componentResourceLocation);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnActivated([In] IActivatedEventArgs args);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnCachedFileUpdaterActivated([In] CachedFileUpdaterActivatedEventArgs args);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnFileActivated([In] FileActivatedEventArgs args);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnFileOpenPickerActivated([In] FileOpenPickerActivatedEventArgs args);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnFileSavePickerActivated([In] FileSavePickerActivatedEventArgs args);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnLaunched([In] LaunchActivatedEventArgs args);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnSearchActivated([In] SearchActivatedEventArgs args);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual void OnShareTargetActivated([In] ShareTargetActivatedEventArgs args);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void Start([In] ApplicationInitializationCallback callback);

        public static Application Current { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.UI.Xaml.DebugSettings DebugSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ApplicationTheme RequestedTheme { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ResourceDictionary Resources { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.UI.Xaml.DebugSettings Windows.UI.Xaml.IApplication.DebugSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ApplicationTheme Windows.UI.Xaml.IApplication.RequestedTheme { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ResourceDictionary Windows.UI.Xaml.IApplication.Resources { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

