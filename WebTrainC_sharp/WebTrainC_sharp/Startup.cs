using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTrainC_sharp.Startup))]
namespace WebTrainC_sharp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
