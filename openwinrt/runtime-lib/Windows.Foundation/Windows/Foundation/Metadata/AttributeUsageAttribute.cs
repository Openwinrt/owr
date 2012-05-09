using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{


    [Windows.Foundation.Metadata.AttributeUsage(Windows.Foundation.Metadata.AttributeTargets.RuntimeClass), Version(0x6020000)]
    public sealed class AttributeUsageAttribute : Attribute
    {

        [MethodImplAttribute((MethodImplOptions)0, MethodCodeType = MethodCodeType.Runtime)]//      MethodCodeType = MethodCodeType.Runtime)]

      //  [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]


        public AttributeUsageAttribute(Windows.Foundation.Metadata.AttributeTargets targets);
    }
}

