using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Viddly3.Startup))]
namespace Viddly3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
