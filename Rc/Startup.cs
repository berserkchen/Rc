using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rc.Startup))]
namespace Rc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
