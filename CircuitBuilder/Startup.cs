using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CircuitBuilder.Startup))]
namespace CircuitBuilder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
