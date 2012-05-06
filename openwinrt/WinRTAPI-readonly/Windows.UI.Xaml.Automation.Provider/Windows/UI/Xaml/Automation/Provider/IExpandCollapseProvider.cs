namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation;

    [Version(0x6020000), Guid(0x49ac8399, 0xd626, 0x4543, 0x94, 0xb9, 0xa6, 0xd9, 0xa9, 0x59, 0x3a, 0xf6), WebHostHidden]
    public interface IExpandCollapseProvider
    {
        void Collapse();
        void Expand();

        Windows.UI.Xaml.Automation.ExpandCollapseState ExpandCollapseState { get; }
    }
}

