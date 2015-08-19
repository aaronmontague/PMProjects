using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PMProjects.Startup))]
namespace PMProjects
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
