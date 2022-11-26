using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DataAccess
{
    public static class DalServiceResgistration
    {
        public static IServiceCollection AddDalServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BaseContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString")));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IStudentDal, StudentDal>();
            services.AddScoped<ICourseDal, CourseDal>();
            return services;
        }
    }
}
