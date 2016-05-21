using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GalileoDemo.Startup))]
namespace GalileoDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
