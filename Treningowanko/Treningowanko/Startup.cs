using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Treningowanko.Startup))]
namespace Treningowanko
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
