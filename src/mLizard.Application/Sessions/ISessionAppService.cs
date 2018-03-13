using System.Threading.Tasks;
using Abp.Application.Services;
using mLizard.Sessions.Dto;

namespace mLizard.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
