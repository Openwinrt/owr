namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Application)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x74b861a1, 0x7487, 0x46a9, 0x9a, 110, 0xc7, 0x8b, 0x51, 0x27, 0x26, 0xc5), WebHostHidden]
    internal interface IApplication
    {
        event Windows.Foundation.EventHandler<object> Resuming;

        event SuspendingEventHandler Suspending;

        event Windows.UI.Xaml.UnhandledExceptionEventHandler UnhandledException;

        void Exit();

        Windows.UI.Xaml.DebugSettings DebugSettings { get; }

        ApplicationTheme RequestedTheme { get; [param: In] set; }

        ResourceDictionary Resources { get; [param: In] set; }
    }
}

