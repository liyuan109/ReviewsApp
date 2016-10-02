using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcReviews.Startup))]
namespace MvcReviews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
