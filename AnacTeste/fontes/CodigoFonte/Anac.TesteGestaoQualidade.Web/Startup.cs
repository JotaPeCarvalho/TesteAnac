using Anac.TesteGestaoQualidade.Infrastructure.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace Anac.TesteGestaoQualidade.Web
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }
        public IWebHostEnvironment Environment { get; set; }

        public Startup(IWebHostEnvironment env)
        {
            Environment = env;

            //carrega configuration files
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true,  reloadOnChange: true)
                .AddJsonFile($"secrets/appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .AddUserSecrets<Startup>();

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureDatabase(services);

            services.AddCorporativo(Environment, Configuration);
			services.AddIntegrations(Configuration, Environment);
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory, IHostApplicationLifetime appLifetime)
        {
            app.UseCorporativo(Environment, Configuration, loggerFactory, appLifetime, false);
        }

        private void ConfigureDatabase(IServiceCollection services)
        {
            services.AddScoped(_ => new DatabaseContext(Configuration.GetConnectionString("Context")));
        }
    }
}
