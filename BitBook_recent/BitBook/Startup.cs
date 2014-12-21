using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BitBook.Startup))]
namespace BitBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
