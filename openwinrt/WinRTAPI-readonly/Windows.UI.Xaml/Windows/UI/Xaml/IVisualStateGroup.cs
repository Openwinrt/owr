namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xe4f9d9a4, 0xe028, 0x44de, 0x9b, 0x15, 0x49, 0x29, 0xae, 10, 0x26, 0xc2), ExclusiveTo(typeof(VisualStateGroup)), Version(0x6020000)]
    internal interface IVisualStateGroup
    {
        event VisualStateChangedEventHandler CurrentStateChanged;

        event VisualStateChangedEventHandler CurrentStateChanging;

        VisualState CurrentState { get; }

        string Name { get; }

        IVector<VisualState> States { get; }

        IVector<VisualTransition> Transitions { get; }
    }
}

