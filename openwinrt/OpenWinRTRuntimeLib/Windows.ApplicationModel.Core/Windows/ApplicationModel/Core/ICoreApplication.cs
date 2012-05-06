namespace Windows.ApplicationModel.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(CoreApplication)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xaacf7a4, 0x5e1d, 0x49df, 0x80, 0x34, 0xfb, 0x6a, 0x68, 0xbc, 0x5e, 0xd1), WebHostHidden]
    internal interface ICoreApplication
    {
        event Windows.Foundation.EventHandler<object> Resuming;

        event Windows.Foundation.EventHandler<SuspendingEventArgs> Suspending;

        CoreApplicationView GetCurrentView();
        [Overload("Run"), DefaultOverload]
        void Run([In] IFrameworkViewSource viewSource);
        [Overload("RunWithActivationFactories")]
        void Run([In] IGetActivationFactory activationFactoryCallback);

        string Id { get; }

        IPropertySet Properties { get; }
    }
}

