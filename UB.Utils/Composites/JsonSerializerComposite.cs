using System;
using System.Collections.Generic;
using System.Text;
using UB.Utils.Enums;
using UB.Utils.Interfaces;

namespace UB.Utils.Composites
{
  public class JsonSerializerComposite : IJsonSerializer
  {
    private readonly Dictionary<JsonSerializerType, IJsonSerializer> _serializers;
    public JsonSerializerComposite(Dictionary<JsonSerializerType, IJsonSerializer> serializers)
    {
      _serializers = serializers;
    }

    public T Deserialize<T>(JsonSerializerType serializerType, string json) =>
      _serializers[serializerType].Deserialize<T>(serializerType, json);

    public string Serialize<T>(JsonSerializerType serializerType, T item) =>
      _serializers[serializerType].Serialize<T>(serializerType, item);
  }
}
