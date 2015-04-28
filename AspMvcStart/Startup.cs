using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspMvcStart.Startup))]
namespace AspMvcStart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //Change

            ///Add some changes
            ConfigureAuth(app);
        }
    }
}
