using System.Threading.Tasks;
using Abp.Application.Services;
using OswaTech.Sessions.Dto;

namespace OswaTech.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
