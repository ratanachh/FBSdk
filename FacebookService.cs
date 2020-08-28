using System.Threading.Tasks;

namespace FBSdk
{
    public interface IFacebookService
    {
        Task<Account> GetAccountAsync(string accessToken);
        Task PostOrWallAsync(string accessToken, string message);
    }
    public class FacebookService : IFacebookService
    {
        private readonly IFacebookClient _facebookClient;

        public FacebookService(IFacebookClient facebookClient)
        {
            _facebookClient = facebookClient;
        }
        
        public Task<Account> GetAccountAsync(string accessToken)
        {
            throw new System.NotImplementedException();
        }

        public Task PostOrWallAsync(string accessToken, string message)
        {
            throw new System.NotImplementedException();
        }
    }
}