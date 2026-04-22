using Soenneker.Tests.HostedUnit;

namespace Soenneker.Rebrickable.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class RebrickableOpenApiClientRunnerTests : HostedUnitTest
{
    public RebrickableOpenApiClientRunnerTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
