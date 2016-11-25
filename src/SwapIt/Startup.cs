using Microsoft.Owin;
using Owin;
using SwapIt;

[assembly: OwinStartup(typeof(Startup))]

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