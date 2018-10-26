using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fabrica.MVC.Startup))]
namespace Fabrica.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
