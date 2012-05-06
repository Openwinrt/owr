namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media.Animation;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(ItemsControl)), Windows.Foundation.Metadata.Guid(0xf4a91dd8, 0xd979, 0x4381, 0x86, 0x52, 0xbd, 160, 0x34, 0x2a, 0x76, 0x5e)]
    internal interface IItemsControl
    {
        string DisplayMemberPath { get; [param: In] set; }

        IObservableVector<Windows.UI.Xaml.Controls.GroupStyle> GroupStyle { get; }

        Windows.UI.Xaml.Controls.GroupStyleSelector GroupStyleSelector { get; [param: In] set; }

        bool IsGrouping { get; }

        Windows.UI.Xaml.Controls.ItemContainerGenerator ItemContainerGenerator { get; }

        Style ItemContainerStyle { get; [param: In] set; }

        StyleSelector ItemContainerStyleSelector { get; [param: In] set; }

        TransitionCollection ItemContainerTransitions { get; [param: In] set; }

        ItemCollection Items { get; }

        ItemsPanelTemplate ItemsPanel { get; [param: In] set; }

        object ItemsSource { get; [param: In] set; }

        DataTemplate ItemTemplate { get; [param: In] set; }

        DataTemplateSelector ItemTemplateSelector { get; [param: In] set; }
    }
}

