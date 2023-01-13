using Corporativo.Infrastructure.IoC.Base;
using Microsoft.Extensions.DependencyInjection;

namespace Anac.TesteGestaoQualidade.Infrastructure.Configuration
{
    public class RegisterTypes : IRegisterService
    {
        public void Register(IServiceCollection services)
        {
            //É possível customizar a injeção de dependência para qualquer tipo desse projeto
            //ex: services.AddScoped<IAeronaveRepository, IAeronaveRepository>();
        }
    }
}
