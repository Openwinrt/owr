namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [Composable(typeof(IVisualStateManagerFactory), CompositionType.Public, 0x6020000), Threading(ThreadingModel.Both), WebHostHidden, Static(typeof(IVisualStateManagerStatics), 0x6020000), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public class VisualStateManager : DependencyObject, IVisualStateManager, IVisualStateManagerOverrides, IVisualStateManagerProtected
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public VisualStateManager();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static VisualStateManager GetCustomVisualStateManager([In] FrameworkElement obj);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static IVector<VisualStateGroup> GetVisualStateGroups([In] FrameworkElement obj);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool GoToState([In] Control control, [In] string stateName, [In] bool useTransitions);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected virtual bool GoToStateCore([In] Control control, [In] FrameworkElement templateRoot, [In] string stateName, [In] VisualStateGroup group, [In] VisualState state, [In] bool useTransitions);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected void RaiseCurrentStateChanged([In] VisualStateGroup stateGroup, [In] VisualState oldState, [In] VisualState newState, [In] Control control);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected void RaiseCurrentStateChanging([In] VisualStateGroup stateGroup, [In] VisualState oldState, [In] VisualState newState, [In] Control control);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetCustomVisualStateManager([In] FrameworkElement obj, [In] VisualStateManager value);

        public static DependencyProperty CustomVisualStateManagerProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

