using Abp.Application.Services;
using AutomaticAcceptanceTest.MultiTenancy.Dto;

namespace AutomaticAcceptanceTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

