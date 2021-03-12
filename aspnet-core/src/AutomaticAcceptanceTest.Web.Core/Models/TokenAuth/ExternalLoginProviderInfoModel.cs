using Abp.AutoMapper;
using AutomaticAcceptanceTest.Authentication.External;

namespace AutomaticAcceptanceTest.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
