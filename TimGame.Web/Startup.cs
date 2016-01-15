using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimGame.Web.Startup))]
namespace TimGame.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
