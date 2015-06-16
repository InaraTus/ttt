using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSampleLab.Startup))]
namespace MVCSampleLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
