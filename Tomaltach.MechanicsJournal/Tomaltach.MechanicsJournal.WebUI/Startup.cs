using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tomaltach.MechanicsJournal.WebUI.Startup))]
namespace Tomaltach.MechanicsJournal.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
