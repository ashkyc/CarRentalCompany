using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentalCarCompany.Startup))]
namespace RentalCarCompany
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
