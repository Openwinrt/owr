namespace Windows.ApplicationModel.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(ICoreApplicationUseCount), 0x6020000), Static(typeof(ICoreImmersiveApplication), 0x6020000), WebHostHidden, Static(typeof(ICoreApplication), 0x6020000), Static(typeof(ICoreApplicationExit), 0x6020000)]
    public static class CoreApplication
    {
        public static  event Windows.Foundation.EventHandler<object> Exiting;

        public static  event Windows.Foundation.EventHandler<object> Resuming;

        public static  event Windows.Foundation.EventHandler<SuspendingEventArgs> Suspending;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static CoreApplicationView CreateNewView([In] string runtimeType, [In] string entryPoint);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void DecrementApplicationUseCount();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void Exit();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static CoreApplicationView GetCurrentView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void IncrementApplicationUseCount();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("Run")]
        public static void Run([In] IFrameworkViewSource viewSource);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RunWithActivationFactories")]
        public static void Run([In] IGetActivationFactory activationFactoryCallback);

        public static string Id { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static CoreApplicationView MainView { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static IPropertySet Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static IVectorView<CoreApplicationView> Views { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

