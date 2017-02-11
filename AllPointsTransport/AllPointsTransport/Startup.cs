using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AllPointsTransport.Startup))]
namespace AllPointsTransport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
