using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsPOC.Startup))]
namespace JenkinsPOC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
