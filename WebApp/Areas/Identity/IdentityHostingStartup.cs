using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApp.Data;
using WebApp.Areas.Identity.Data;

[assembly: HostingStartup(typeof(WebApp.Areas.Identity.IdentityHostingStartup))]
namespace WebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AccountContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AccountContextConnection")));

                services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AccountContext>();

                //services.AddAuthentication(o =>
                //{
                //    o.DefaultScheme = IdentityConstants.ApplicationScheme;
                //    o.DefaultSignInScheme = IdentityConstants.ExternalScheme;
                //})
                //.AddIdentityCookies(o => { });

                //services.AddIdentityCore<AppUser>(o =>
                //{
                //    o.Stores.MaxLengthForKeys = 128;
                //    o.SignIn.RequireConfirmedAccount = true;
                //})
                //.AddDefaultUI()
                //.AddDefaultTokenProviders();
            });
        }
    }
}