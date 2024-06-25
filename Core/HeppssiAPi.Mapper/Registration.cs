 
using Microsoft.Extensions.DependencyInjection;
using HeppssiAPi.Application.Interfaces.AutoMapper;

namespace HeppssiAPi.Mapper
{
    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, AutoMapper.Mapper>();
        }
    }
}