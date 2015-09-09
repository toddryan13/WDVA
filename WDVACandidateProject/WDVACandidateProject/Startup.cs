using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WDVACandidateProject.Startup))]
namespace WDVACandidateProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
