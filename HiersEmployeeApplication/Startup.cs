using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HiersEmployeeApplication.Startup))]
namespace HiersEmployeeApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
