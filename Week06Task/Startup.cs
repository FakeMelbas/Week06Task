using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week06Task.Startup))]
namespace Week06Task
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
