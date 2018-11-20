using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MediatR;
using Seirin.Persistence;
using Microsoft.EntityFrameworkCore;
using Seirin.Application.Users.Commands;
using System.Reflection;

namespace SeirinAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Add MediatR
            services.AddMediatR(typeof(RegisterUserHandle).GetTypeInfo().Assembly);

            // Add DbContext
            //Server=DESKTOP-NB02KAV;Database=Seirin;Trusted_Connection=True;User Id=sa;Password=123123
            services.AddDbContext<DbContextSeirin>(op => op.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDbContext<DbContextSeirin>(options => options.UseSqlServer(@"Server=DESKTOP-NB02KAV;Database=Seirin;Trusted_Connection=True;User Id=sa;Password=123123"));
            //services.AddDbContext<DbContextSeirin>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            //);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
