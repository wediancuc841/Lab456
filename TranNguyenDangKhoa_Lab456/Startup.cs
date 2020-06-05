using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranNguyenDangKhoa_Lab456.Startup))]
namespace TranNguyenDangKhoa_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
