using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyChatApp.Startup))]
namespace MyChatApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
