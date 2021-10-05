using System;
using System.IO;
using System.Threading.Tasks;
using UB.Utils.Interfaces;

namespace UB.Utils.Services
{
  public class StreamReaderService : IStreamReaderService
  {
    public async Task<string> ReadToEndAsync(Stream stream)
    {
      if (stream == null) throw new ArgumentNullException(nameof(stream));

      using var sr = new StreamReader(stream);
      return await sr.ReadToEndAsync();
    }
  }
}
