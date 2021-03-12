using Abp.Application.Services.Dto;

namespace AutomaticAcceptanceTest.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

