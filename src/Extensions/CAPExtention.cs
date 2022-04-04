using System;
using DotNetCore.CAP;
using Furion;
using System.Linq;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// CAP Extention class
    /// </summary>
    public static class CAPExtension
    {
        /// <summary>
        /// Add furion dotnet cap
        /// </summary>
        /// <param name="services">service collection</param>
        /// <param name="option">CAP option</param>
        /// <returns></returns>
        public static IServiceCollection AddFurionCap(this IServiceCollection services,Action<CapOptions> option)
        {
            var assemblies = App.Assemblies.ToArray();
            var builder = services.AddCap(option);
            
            // scan all  ICapSubscriber
            if (assemblies != null && assemblies.Length > 0) builder.AddSubscriberAssembly(assemblies);

            return services;
        }
    }
}
