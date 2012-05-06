namespace Windows.Data.Xml.Dom
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum NodeType
    {
        Invalid,
        ElementNode,
        AttributeNode,
        TextNode,
        DataSectionNode,
        EntityReferenceNode,
        EntityNode,
        ProcessingInstructionNode,
        CommentNode,
        DocumentNode,
        DocumentTypeNode,
        DocumentFragmentNode,
        NotationNode
    }
}

