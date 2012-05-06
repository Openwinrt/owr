namespace Windows.Data.Json
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Threading(ThreadingModel.Both), DualApiPartition(version=0x6020000), Version(0x6020000), Static(typeof(IJsonObjectStatics), 0x6020000), Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class JsonObject : IJsonObject, IJsonValue, IMap<string, IJsonValue>, IIterable<IKeyValuePair<string, IJsonValue>>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public JsonObject();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<IKeyValuePair<string, IJsonValue>> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public JsonArray GetArray();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool GetBoolean();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public JsonArray GetNamedArray([In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool GetNamedBoolean([In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public double GetNamedNumber([In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public JsonObject GetNamedObject([In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetNamedString([In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public JsonValue GetNamedValue([In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public double GetNumber();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public JsonObject GetObject();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetString();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IMapView<string, IJsonValue> GetView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool HasKey([In] string key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool Insert([In] string key, [In] IJsonValue value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IJsonValue Lookup([In] string key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static JsonObject Parse([In] string input);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Remove([In] string key);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetNamedValue([In] string name, [In] IJsonValue value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string Stringify();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool TryParse([In] string input, out JsonObject result);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public JsonValueType ValueType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public JsonValueType Windows.Data.Json.IJsonValue.ValueType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

