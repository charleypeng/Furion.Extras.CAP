using System;
using DotNetCore.CAP;
using Furion;
using System.Linq;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// 对象映射拓展类
    /// </summary>
    public static class CAPExtension
    {
        /// <summary>
        /// 添加对象映射
        /// </summary>
        /// <param name="services">服务集合</param>
        /// <param name="option">CAP配置</param>
        /// <returns></returns>
        public static IServiceCollection AddFurionCap(this IServiceCollection services,Action<CapOptions> option)
        {
            var assemblies = App.Assemblies.ToArray();
            var builder = services.AddCap(option);
            
            // 扫描所有继承  ICapSubscriber 接口的对象映射配置
            if (assemblies != null && assemblies.Length > 0) builder.AddSubscriberAssembly(assemblies);

            return services;
        }
    }
}