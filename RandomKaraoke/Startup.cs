using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RandomKaraoke.Models;
using Microsoft.EntityFrameworkCore;
using RandomKaraoke.Models.Entities;

namespace RandomKaraoke
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //var connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LipsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            var connString = @"Server=tcp:carsaa.database.windows.net,1433;Initial Catalog=RandomKaraoke;Persist Security Info=False;User ID=carsaa;Password=Singsingsing00;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            services.AddDbContext<SongDBContext>(options => options.UseSqlServer(connString));
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();

        }
    }
}
