using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AutomaticAcceptanceTest.Configuration.Dto;

namespace AutomaticAcceptanceTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AutomaticAcceptanceTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
