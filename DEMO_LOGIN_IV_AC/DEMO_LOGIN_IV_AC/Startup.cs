using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DEMO_LOGIN_IV_AC.Startup))]
namespace DEMO_LOGIN_IV_AC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
