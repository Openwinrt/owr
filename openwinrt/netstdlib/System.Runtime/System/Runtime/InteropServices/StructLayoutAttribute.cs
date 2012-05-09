using System;

namespace System.Runtime.InteropServices
{
  

    [AttributeUsage(12, Inherited=false)]
    public sealed class StructLayoutAttribute : Attribute
    {
        public System.Runtime.InteropServices.CharSet CharSet;
        public int Pack;
        public int Size;

        public StructLayoutAttribute(LayoutKind layoutKind)
        {
            Value = layoutKind;
        }

        public LayoutKind Value  { get; private set;}
    }
}

