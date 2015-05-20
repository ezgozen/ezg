using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hotelmanage.Startup))]
namespace hotelmanage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
