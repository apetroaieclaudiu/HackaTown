using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HackaTown.Startup))]
namespace HackaTown
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
