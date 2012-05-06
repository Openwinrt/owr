namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Markup;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), WebHostHidden, Version(0x6020000), Activatable(0x6020000), ContentProperty(Name="States")]
    public sealed class VisualStateGroup : DependencyObject, IVisualStateGroup
    {
        public event VisualStateChangedEventHandler CurrentStateChanged;

        public event VisualStateChangedEventHandler CurrentStateChanging;

        public event VisualStateChangedEventHandler Windows.UI.Xaml.IVisualStateGroup.CurrentStateChanged;

        public event VisualStateChangedEventHandler Windows.UI.Xaml.IVisualStateGroup.CurrentStateChanging;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public VisualStateGroup();

        public VisualState CurrentState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<VisualState> States { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<VisualTransition> Transitions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public VisualState Windows.UI.Xaml.IVisualStateGroup.CurrentState { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Xaml.IVisualStateGroup.Name { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<VisualState> Windows.UI.Xaml.IVisualStateGroup.States { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<VisualTransition> Windows.UI.Xaml.IVisualStateGroup.Transitions { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

