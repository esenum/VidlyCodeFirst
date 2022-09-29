using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyCF.Startup))]
namespace VidlyCF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
