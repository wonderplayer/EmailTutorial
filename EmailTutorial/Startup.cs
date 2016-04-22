using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmailTutorial.Startup))]
namespace EmailTutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
