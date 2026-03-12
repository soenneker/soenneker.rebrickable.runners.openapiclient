using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Rebrickable.Runners.OpenApiClient.Utils.Abstract;

public interface IFileOperationsUtil
{
    ValueTask Process(CancellationToken cancellationToken = default);
}
