﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVenta.DAL.DBContext;

namespace SistemaVenta.IOC
{
    public static class Dependencia
    {
        public static void inyectarDependencias(this IServiceCollection services, IConfiguration configuration){
            services.AddDbContext<DbventaContext>(options =>{
                options.UseSqlServer(configuration.GetConnectionString("CadenaSQL"));
            });
        }
    }
}
