using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FunkyHippo.Startup))]
namespace FunkyHippo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
