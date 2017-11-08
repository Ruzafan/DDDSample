using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DDD_Sample.Startup))]
namespace DDD_Sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
