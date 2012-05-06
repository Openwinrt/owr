namespace Windows.UI.Xaml
{
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Threading(ThreadingModel.Both), Version(0x6020000), Composable(typeof(ITriggerActionFactory), CompositionType.Protected, 0x6020000)]
    public class TriggerAction : DependencyObject, ITriggerAction
    {
    }
}

