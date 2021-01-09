using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BIPIT10.Startup))]
namespace BIPIT10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
