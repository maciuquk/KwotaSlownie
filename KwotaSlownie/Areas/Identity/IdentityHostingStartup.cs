using System;
using KwotaSlownie.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(KwotaSlownie.Areas.Identity.IdentityHostingStartup))]
namespace KwotaSlownie.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<KwotaSlownieContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("KwotaSlownieContextConnection")));

                services.AddDefaultIdentity<KwotaSlownieUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<KwotaSlownieContext>();
            });
        }
    }
}