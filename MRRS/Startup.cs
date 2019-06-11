using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MRRS.Startup))]
namespace MRRS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
