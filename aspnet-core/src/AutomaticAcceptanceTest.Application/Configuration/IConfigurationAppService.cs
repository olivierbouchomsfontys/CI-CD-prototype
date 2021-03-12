using System.Threading.Tasks;
using AutomaticAcceptanceTest.Configuration.Dto;

namespace AutomaticAcceptanceTest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
