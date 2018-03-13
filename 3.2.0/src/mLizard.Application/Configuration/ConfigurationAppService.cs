using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using mLizard.Configuration.Dto;

namespace mLizard.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : mLizardAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
