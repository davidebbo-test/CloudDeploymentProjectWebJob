using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CloudDeploymentProject1.Startup))]
namespace CloudDeploymentProject1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
