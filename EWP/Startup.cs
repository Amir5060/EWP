using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EWP.Startup))]
namespace EWP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
