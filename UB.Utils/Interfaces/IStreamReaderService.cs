using System.IO;
using System.Threading.Tasks;

namespace UB.Utils.Interfaces
{
  public interface IStreamReaderService
  {
    Task<string> ReadToEndAsync(Stream stream);
  }
}
