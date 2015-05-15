using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SGS_Web.Startup))]
namespace SGS_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
