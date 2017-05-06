using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(leduchai.Web.Startup))]
namespace leduchai.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
