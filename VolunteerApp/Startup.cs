using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VolunteerApp.Startup))]
namespace VolunteerApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app); // mjbtest
        }
    }
}
