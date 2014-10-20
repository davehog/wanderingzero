using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WanderingZero.Startup))]
namespace WanderingZero
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
