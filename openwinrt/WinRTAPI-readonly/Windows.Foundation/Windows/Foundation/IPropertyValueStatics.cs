namespace Windows.Foundation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PropertyValue)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x629bdbc8, 0xd932, 0x4ff4, 150, 0xb9, 0x8d, 150, 0xc5, 0xc1, 0xe8, 0x58)]
    internal interface IPropertyValueStatics
    {
        object CreateBoolean([In] bool value);
        object CreateBooleanArray([In] bool[] value);
        object CreateChar16([In] char value);
        object CreateChar16Array([In] char[] value);
        object CreateDateTime([In] Windows.Foundation.DateTime value);
        object CreateDateTimeArray([In] Windows.Foundation.DateTime[] value);
        object CreateDouble([In] double value);
        object CreateDoubleArray([In] double[] value);
        object CreateEmpty();
        object CreateGuid([In] Guid value);
        object CreateGuidArray([In] Guid[] value);
        object CreateInspectable([In] object value);
        object CreateInspectableArray([In] object[] value);
        object CreateInt16([In] short value);
        object CreateInt16Array([In] short[] value);
        object CreateInt32([In] int value);
        object CreateInt32Array([In] int[] value);
        object CreateInt64([In] long value);
        object CreateInt64Array([In] long[] value);
        object CreatePoint([In] Point value);
        object CreatePointArray([In] Point[] value);
        object CreateRect([In] Rect value);
        object CreateRectArray([In] Rect[] value);
        object CreateSingle([In] float value);
        object CreateSingleArray([In] float[] value);
        object CreateSize([In] Size value);
        object CreateSizeArray([In] Size[] value);
        object CreateString([In] string value);
        object CreateStringArray([In] string[] value);
        object CreateTimeSpan([In] Windows.Foundation.TimeSpan value);
        object CreateTimeSpanArray([In] Windows.Foundation.TimeSpan[] value);
        object CreateUInt16([In] ushort value);
        object CreateUInt16Array([In] ushort[] value);
        object CreateUInt32([In] uint value);
        object CreateUInt32Array([In] uint[] value);
        object CreateUInt64([In] ulong value);
        object CreateUInt64Array([In] ulong[] value);
        object CreateUInt8([In] byte value);
        object CreateUInt8Array([In] byte[] value);
    }
}

