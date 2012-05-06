namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class ComboBoxTemplateSettings : DependencyObject, IComboBoxTemplateSettings
    {
        public double DropDownClosedHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double DropDownOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double DropDownOpenedHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public AnimationDirection SelectedItemDirection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IComboBoxTemplateSettings.DropDownClosedHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IComboBoxTemplateSettings.DropDownOffset { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.UI.Xaml.Controls.Primitives.IComboBoxTemplateSettings.DropDownOpenedHeight { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public AnimationDirection Windows.UI.Xaml.Controls.Primitives.IComboBoxTemplateSettings.SelectedItemDirection { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

