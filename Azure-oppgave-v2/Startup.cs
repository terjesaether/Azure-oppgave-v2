using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Azure_oppgave_v2.Startup))]
namespace Azure_oppgave_v2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
