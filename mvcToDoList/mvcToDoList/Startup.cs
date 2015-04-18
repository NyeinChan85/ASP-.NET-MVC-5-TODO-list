using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcToDoList.Startup))]
namespace mvcToDoList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
