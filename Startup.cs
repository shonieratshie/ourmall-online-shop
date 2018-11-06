using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OurMallWebApp.Startup))]
namespace OurMallWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
