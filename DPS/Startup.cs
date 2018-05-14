using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DPS.Startup))]
namespace DPS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
