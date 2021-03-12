using System.Threading.Tasks;
using Abp.Application.Services;
using AutomaticAcceptanceTest.Sessions.Dto;

namespace AutomaticAcceptanceTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
