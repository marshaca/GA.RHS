using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GA.RHS.Startup))]
namespace GA.RHS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
