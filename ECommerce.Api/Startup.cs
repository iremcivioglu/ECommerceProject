using ECommerce.Api.Helpers;
using ECommerce.Api.Sevices;
using ECommerce.Business.Abstract;
using ECommerce.Business.Concrete;
using ECommerce.DataAccess;
using ECommerce.DataAccess.Concrete;
using ECommerce.DataAccess.Repositories;
using ECommerce.Entities;
using ECommerce.Entities.Model;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        //private void ConfigureDatabaseOptions(DbContextOptionsBuilder builder)
        //{
        //    builder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), ConfigureSqlServerDatabaseOptions);
        //}


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson();
            services.AddScoped<IUnitOfWork, UnitOfWork>(); //aynı olan her request için aynı sonucu oluştururum
            services.AddScoped<ICategoryServices, CategoryServices>();
            services.AddTransient<GenericHelperMethods>();
            services.AddIdentity<Users, AppRole>().AddEntityFrameworkStores<ECommerceDbText>();
            //services.AddMvc().AddRazorPagesOptions(opt => opt.Conventions.AddPageRoute("/Login", ""));
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt => opt.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = true,//Token deðerini kimlerin-hangi uygulamaların kullanacağını belirler
                ValidateIssuer = true,//oluşturulan token değerini kim dağıtıyor
                ValidateLifetime = true,//Oluşturulan token değerinin yaşam süresi
                ValidateIssuerSigningKey = true, //Üretilen token deðerinin uygulamamıza ait olup olmadığı ile alakalı security key'i
                ValidIssuer = Configuration["Token:Issuer"], //
                ValidAudience = Configuration["Token:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Token:Securitykey"])),
                ClockSkew = TimeSpan.Zero //Token süresinin uzatılmasını sağlar
            });
            // var myMaxModelBindingCollectionSize = Convert.ToInt32(
            //Configuration["MyMaxModelBindingCollectionSize"] ?? "100");

            //services.Configure<MvcOptions>(options =>
            //       options.MaxModelBindingCollectionSize = myMaxModelBindingCollectionSize);
            services.AddDbContext<ECommerceDbText>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddHttpContextAccessor();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            // services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICustomerServices, CustomerServices>();
            services.AddTransient<IActionContextAccessor, ActionContextAccessor>();
            services.AddScoped<IRazorRenderService, RazorRenderService>();
            services.AddCors(options =>
     options.AddDefaultPolicy(builder =>
     builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));
            services.AddSwaggerDocument();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseRouting();
            //app.UseDefaultFiles();
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseStaticFiles();
            //app.UseDeveloperExceptionPage();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
            });
        }
    }
}
