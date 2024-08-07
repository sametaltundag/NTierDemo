using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Smt.TodoAppNTier.Business.Interfaces;
using Smt.TodoAppNTier.Business.Services;
using Smt.TodoAppNTier.DataAccess.Context;
using Smt.TodoAppNTier.DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smt.TodoAppNTier.Business.Dependency.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<TodoContext>(opt =>
            {
                opt.UseSqlServer("server=DESKTOP-0DTVQK3\\SQLEXPRESS; database=TodoDB; integrated security=true;");
            });
            services.AddScoped<IUow, Uow>();
            services.AddScoped<IWorkService,WorkService>();
        }
    }
}
