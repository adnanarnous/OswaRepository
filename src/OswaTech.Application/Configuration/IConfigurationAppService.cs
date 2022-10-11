using System.Threading.Tasks;
using OswaTech.Configuration.Dto;

namespace OswaTech.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
