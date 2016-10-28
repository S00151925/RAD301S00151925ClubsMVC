using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RAD301S00151925Clubs.Startup))]
namespace RAD301S00151925Clubs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
