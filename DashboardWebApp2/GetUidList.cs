using Microsoft.Extensions.Configuration;

namespace DashboardWebApp2
{
    public class GetUidList(IConfiguration configuration)
    {
        public List<string> UidList = new List<string> { configuration["Secrets:Uids"] };
    }
}
