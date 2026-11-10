using Soenneker.Tests.HostedUnit;

namespace Soenneker.Google.Meet.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class GoogleMeetOpenApiClientTests : HostedUnitTest
{
    public GoogleMeetOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
