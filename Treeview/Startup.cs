using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TreeView.Startup))]
namespace TreeView
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}