using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VIPProgramAssessment.Startup))]
namespace VIPProgramAssessment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
