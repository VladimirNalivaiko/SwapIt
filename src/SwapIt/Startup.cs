using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SwapIt.Startup))]
namespace SwapIt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
