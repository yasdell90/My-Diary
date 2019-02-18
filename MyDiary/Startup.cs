using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyDiary.Startup))]
namespace MyDiary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
