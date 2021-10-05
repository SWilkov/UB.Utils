using Newtonsoft.Json;
using System;
using UB.Utils.Enums;
using UB.Utils.Interfaces;

namespace UB.Utils.Services
{
  public class JsonNetSerializer : IJsonSerializer
  {
    public T Deserialize<T>(JsonSerializerType serializerType, string json) 
    {
      if (string.IsNullOrWhiteSpace(json)) throw new ArgumentNullException(nameof(json));
      if (serializerType != JsonSerializerType.JsonNet)
        throw new ArgumentException($"Invalid type detected: {serializerType}");

      return JsonConvert.DeserializeObject<T>(json);
    }

    public string Serialize<T>(JsonSerializerType serializerType, T item)
    {
      if (item == null) throw new ArgumentNullException(nameof(item));
      if (serializerType != JsonSerializerType.JsonNet)
        throw new ArgumentException($"Invalid type detected: {serializerType}");

      return JsonConvert.SerializeObject(item);
    }
  }
}
