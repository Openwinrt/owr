namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Automation.Text;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x274688d, 0x6e9, 0x4f66, 0x94, 70, 40, 0xa5, 190, 0x98, 0xfb, 0xd0), WebHostHidden]
    public interface ITextRangeProvider
    {
        void AddToSelection();
        ITextRangeProvider Clone();
        bool Compare([In] ITextRangeProvider textRangeProvider);
        int CompareEndpoints([In] TextPatternRangeEndpoint endpoint, [In] ITextRangeProvider textRangeProvider, [In] TextPatternRangeEndpoint targetEndpoint);
        void ExpandToEnclosingUnit([In] TextUnit unit);
        ITextRangeProvider FindAttribute([In] int attributeId, [In] object value, [In] bool backward);
        ITextRangeProvider FindText([In] string text, [In] bool backward, [In] bool ignoreCase);
        object GetAttributeValue([In] int attributeId);
        void GetBoundingRectangles(out double[] returnValue);
        IRawElementProviderSimple[] GetChildren();
        IRawElementProviderSimple GetEnclosingElement();
        string GetText([In] int maxLength);
        int Move([In] TextUnit unit, [In] int count);
        void MoveEndpointByRange([In] TextPatternRangeEndpoint endpoint, [In] ITextRangeProvider textRangeProvider, [In] TextPatternRangeEndpoint targetEndpoint);
        int MoveEndpointByUnit([In] TextPatternRangeEndpoint endpoint, [In] TextUnit unit, [In] int count);
        void RemoveFromSelection();
        void ScrollIntoView([In] bool alignToTop);
        void Select();
    }
}

