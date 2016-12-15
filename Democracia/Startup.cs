using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Democracia.Startup))]
namespace Democracia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
