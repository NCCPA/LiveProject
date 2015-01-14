using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hospice.Startup))]
namespace Hospice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
