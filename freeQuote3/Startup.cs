using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(freeQuote3.Startup))]
namespace freeQuote3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
