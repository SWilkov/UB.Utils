using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using UB.Utils.Enums;
using UB.Utils.Interfaces;
using UB.Utils.Services;

namespace UB.Utils.Extensions
{
  public static class ServiceCollectionExtensions
  {
    public static void AddUBUtils(this IServiceCollection services)
    {
      services.AddScoped<IStreamReaderService, StreamReaderService>();

      services.AddScoped<IJsonSerializer>(sp =>
      {
        var serializers = new Dictionary<JsonSerializerType, IJsonSerializer>
        {
          {
            JsonSerializerType.JsonNet,
            new JsonNetSerializer()
          },
          {
            JsonSerializerType.JsonText,
            new JsonTextSerializer()
          }
        };

        return new Composites.JsonSerializerComposite(serializers);
      });
    }
  }
}
