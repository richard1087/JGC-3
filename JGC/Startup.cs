using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JGC.Startup))]
namespace JGC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
