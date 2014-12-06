using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BitbookApp.Startup))]
namespace BitbookApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
