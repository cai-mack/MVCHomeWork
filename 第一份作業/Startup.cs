using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstWeekWork.Startup))]
namespace FirstWeekWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
