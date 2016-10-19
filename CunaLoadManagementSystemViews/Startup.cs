using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CunaLoadManagementSystemViews.Startup))]
namespace CunaLoadManagementSystemViews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
