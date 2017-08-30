using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(enquiryform2.Startup))]
namespace enquiryform2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
