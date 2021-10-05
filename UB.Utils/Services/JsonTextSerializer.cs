using System;
using System.Text.Json;
using UB.Utils.Enums;

namespace UB.Utils.Services
{
  public class JsonTextSerializer : Interfaces.IJsonSerializer
  {
    public T Deserialize<T>(JsonSerializerType serializerType, string json)
    {
      if (string.IsNullOrWhiteSpace(json)) throw new ArgumentNullException(nameof(json));
      if (serializerType != JsonSerializerType.JsonText)
        throw new ArgumentException($"Invalid type detected: {serializerType}");

      return JsonSerializer.Deserialize<T>(json);
    }

    public string Serialize<T>(JsonSerializerType serializerType, T item)
    {
      if (item == null)
        throw new ArgumentNullException(nameof(item));
      if (serializerType != JsonSerializerType.JsonText)
        throw new ArgumentException($"Invalid type detected: {serializerType}");

      return JsonSerializer.Serialize(item);
    }
  }
}
