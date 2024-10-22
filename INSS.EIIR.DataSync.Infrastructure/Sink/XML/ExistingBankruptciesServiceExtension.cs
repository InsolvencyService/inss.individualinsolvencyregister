﻿using INSS.EIIR.AzureSearch.IndexMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.EIIR.DataSync.Infrastructure.Sink.XML
{
    public static class ExistingBankruptciesServiceExtension
    {
        public static IServiceCollection AddExistingBankrupticesService(this IServiceCollection services, ExistingBankruptciesOptions options)
        {

            if (options.BlobStorageConnectionString.IsNullOrEmpty())
                throw new ArgumentNullException("For ExistingBankruptciesOptions, TargetBlobConnectionString is required");

            if (options.BlobStorageContainer.IsNullOrEmpty())
                options.BlobStorageContainer = "existingbankruptcies";

            if (options.ExistingBankruptciesFileName.IsNullOrEmpty())
                options.ExistingBankruptciesFileName = "existingbankruptcies.json";

            services.AddSingleton<IExistingBankruptciesService>(new ExistingBankruptciesService(options));

            return services;
        }

    }
}
