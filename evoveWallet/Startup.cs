using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using evoveWallet.Data;
using evoveWallet.Data.Interfaces;
using evoveWallet.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace evoveWallet
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Register Database Context
            services.AddDbContext<EvoveContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultSqlConnection"));
            }); 
            
            // Register Interfaces and Repositories
            services.AddScoped<IUserAccountRepository, UserAccountRepository>();
            services.AddScoped<ICurrencyRepository, CurrencyRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<ITransactionRepository, TransactionRespository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
            services.AddScoped<IWalletRepository, WalletRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
