using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesMVC_inClass.Startup))]
namespace MoviesMVC_inClass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
