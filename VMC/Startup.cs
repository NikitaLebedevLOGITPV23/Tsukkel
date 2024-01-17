using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VMC.Startup))]
namespace VMC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
