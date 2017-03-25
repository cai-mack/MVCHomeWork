using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecondWeekWork.Startup))]
namespace SecondWeekWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
