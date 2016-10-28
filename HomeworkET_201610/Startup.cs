using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeworkET_201610.Startup))]
namespace HomeworkET_201610
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
