using Abp.Application.Services;
using Abp.Application.Services.Dto;
using mLizard.MultiTenancy.Dto;

namespace mLizard.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
