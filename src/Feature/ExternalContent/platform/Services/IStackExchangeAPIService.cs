using Mvp.Feature.ExternalContent.Models;
using System.Threading.Tasks;

namespace Mvp.Feature.ExternalContent.Services
{
    public interface IStackExchangeAPIService
     {
        Task<StackExchangeUsersModel> GetstackExchangeUsers();
    }
}
