namespace Windows.UI.Xaml
{
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Version(0x6020000), Composable(typeof(ITriggerBaseFactory), CompositionType.Protected, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden]
    public class TriggerBase : DependencyObject, ITriggerBase
    {
    }
}

