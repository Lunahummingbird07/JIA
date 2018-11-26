using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JIA.Startup))]
namespace JIA
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
