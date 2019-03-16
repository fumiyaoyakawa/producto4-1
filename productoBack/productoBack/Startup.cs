using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(productoBack.Startup))]
namespace productoBack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
