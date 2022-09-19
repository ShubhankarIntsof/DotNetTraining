using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NonCore_WebApp_2.Startup))]
namespace NonCore_WebApp_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
