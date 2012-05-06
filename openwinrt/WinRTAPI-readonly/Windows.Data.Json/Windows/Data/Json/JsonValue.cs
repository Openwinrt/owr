namespace Windows.Data.Json
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Static(typeof(IJsonValueStatics), 0x6020000), Version(0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), DualApiPartition(version=0x6020000), WebHostHidden]
    public sealed class JsonValue : IJsonValue
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static JsonValue CreateBooleanValue([In] bool input);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static JsonValue CreateNumberValue([In] double input);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static JsonValue CreateStringValue([In] string input);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public JsonArray GetArray();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool GetBoolean();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public double GetNumber();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public JsonObject GetObject();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetString();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static JsonValue Parse([In] string input);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string Stringify();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool TryParse([In] string input, out JsonValue result);

        public JsonValueType ValueType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public JsonValueType Windows.Data.Json.IJsonValue.ValueType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

