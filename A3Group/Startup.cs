using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A3Group.Startup))]
namespace A3Group
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
