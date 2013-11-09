using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(FreeTime.Models.Startup))]

namespace FreeTime.Models
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}