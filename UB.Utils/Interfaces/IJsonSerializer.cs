using UB.Utils.Enums;

namespace UB.Utils.Interfaces
{
  public interface IJsonSerializer
  {
    T Deserialize<T>(JsonSerializerType serializerType, string json);
    string Serialize<T>(JsonSerializerType serializerType, T item);
  }
}
