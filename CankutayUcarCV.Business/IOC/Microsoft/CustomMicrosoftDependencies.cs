using CankutayUcarCV.Business.Abstract;
using CankutayUcarCV.Business.Concrete;
using CankutayUcarCV.DataAccess.Abstract;
using CankutayUcarCV.DataAccess.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.SqlClient;
using CankutayUcarCV.Business.Validators.DeneyimlerValidator;
using CankutayUcarCV.Business.Validators.EgitimValidator;
using FluentValidation;

namespace CankutayUcarCV.Business.IOC.Microsoft
{
    public static class CustomMicrosoftDependencies
    {
        public static void AddInjections(this WebApplicationBuilder wab)
        {
            var constr = wab.Configuration.GetConnectionString("MsSqlServerConnection");
            wab.Services.AddSingleton<IDbConnection>(con =>
                new SqlConnection(constr));
            wab.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            wab.Services.AddScoped(typeof(IService<>), typeof(Service<>));
            wab.Services.AddValidatorsFromAssemblyContaining(typeof(EgitimEkleValidator));
        }  
    }
}
