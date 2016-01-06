using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimTimGame.Web.Startup))]
namespace TimTimGame.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
