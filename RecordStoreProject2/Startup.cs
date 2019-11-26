using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecordStoreProject2.Startup))]
namespace RecordStoreProject2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
