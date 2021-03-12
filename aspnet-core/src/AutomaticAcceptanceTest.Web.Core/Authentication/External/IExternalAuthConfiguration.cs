using System.Collections.Generic;

namespace AutomaticAcceptanceTest.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
