using Abp.Application.Services;
using OswaTech.MultiTenancy.Dto;

namespace OswaTech.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

