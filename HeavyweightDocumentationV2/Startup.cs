using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HeavyweightDocumentationV2.Startup))]
namespace HeavyweightDocumentationV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
