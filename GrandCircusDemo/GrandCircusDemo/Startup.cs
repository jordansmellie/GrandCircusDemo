using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GrandCircusDemo.Startup))]
namespace GrandCircusDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
