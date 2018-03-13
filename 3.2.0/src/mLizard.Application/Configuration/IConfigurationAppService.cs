using System.Threading.Tasks;
using Abp.Application.Services;
using mLizard.Configuration.Dto;

namespace mLizard.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}