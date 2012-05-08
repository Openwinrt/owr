namespace Windows.Foundation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Static(typeof(IPropertyValueStatics), 0x6020000), Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden]
    public static class PropertyValue
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateBoolean([In] bool value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateBooleanArray([In] bool[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateChar16([In] char value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateChar16Array([In] char[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateDateTime([In] Windows.Foundation.DateTime value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateDateTimeArray([In] Windows.Foundation.DateTime[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateDouble([In] double value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateDoubleArray([In] double[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateEmpty();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateGuid([In] Guid value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateGuidArray([In] Guid[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateInspectable([In] object value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateInspectableArray([In] object[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateInt16([In] short value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateInt16Array([In] short[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateInt32([In] int value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateInt32Array([In] int[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateInt64([In] long value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateInt64Array([In] long[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreatePoint([In] Point value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreatePointArray([In] Point[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateRect([In] Rect value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateRectArray([In] Rect[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateSingle([In] float value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateSingleArray([In] float[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateSize([In] Size value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateSizeArray([In] Size[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateString([In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateStringArray([In] string[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateTimeSpan([In] Windows.Foundation.TimeSpan value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateTimeSpanArray([In] Windows.Foundation.TimeSpan[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateUInt16([In] ushort value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateUInt16Array([In] ushort[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateUInt32([In] uint value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateUInt32Array([In] uint[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateUInt64([In] ulong value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateUInt64Array([In] ulong[] value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateUInt8([In] byte value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static object CreateUInt8Array([In] byte[] value);
    }
}

