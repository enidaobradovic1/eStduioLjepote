using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Database1;
using eStudioLjepote.WebAPI.Filters;
using eStudioLjepote.WebAPI.Security;
using eStudioLjepote.WebAPI.Services_;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace eStudioLjepote.WebAPI
{
    public class BasicAuthDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        };

            swaggerDoc.Security = new[] { securityRequirements };
        }
    }

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
            services.AddMvc(x=>x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
            });
            services.AddAutoMapper();

            services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddScoped<IZaposleniciService, ZaposleniciService>();
            services.AddScoped<IUslugeService, UslugeService>();
            services.AddScoped<IService<Model.VrsteProizvoda, object>, BaseService<Model.VrsteProizvoda, object, VrstaProizvoda>>();
            services.AddScoped<IService<Model.Grad,object>, BaseService<Model.Grad,object,Grad>>();

          
            services.AddScoped<ICRUDService<Model.Proizvod, ProizvodSearchRequest, ProizvodUpsertRequest, ProizvodUpsertRequest>, ProizvodiService>();
            services.AddScoped<IService<Model.Uloge, object>, BaseService<Model.Uloge, object, Uloge>>();
            services.AddScoped<IService<Model.TipUplate, object>, BaseService<Model.TipUplate, object, TipUplate>>();
            services.AddScoped<ICRUDService<Model.Klijent,KlijentiSearchRequest,KlijentiUpsertRequest,KlijentiUpsertRequest>, KlijentiService>();

            services.AddScoped<ICRUDService<Model.Rezervacija, RezervacijeSearchRequest, RezervacijaInsertRequest, RezervacijeUpdateRequest>, RezervacijeService>();
            services.AddScoped<ICRUDService<Model.Uplate, UplateSearchRequest, UplateUpsertRequest, UplateUpsertRequest>,UplateService >();
            services.AddScoped<ICRUDService<Model.Plata, PlataSearchRequest, PlataUpsertRequest, PlataUpsertRequest>, PlataService>();
            services.AddScoped<ICRUDService<Model.Ocjene, OcjeneSearchRequest, OcjeneUpsertRequest, OcjeneUpsertRequest>, OcjeneService>();

            var connection = @"Server=.;Database=150023;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<_150023Context>(options => options.UseSqlServer(connection));
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseAuthentication();

           // app.UseHttpsRedirection();
            app.UseMvc();
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
