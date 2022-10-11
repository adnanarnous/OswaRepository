using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using OswaTech.Configuration.Dto;

namespace OswaTech.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OswaTechAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
