using System;
using System.Collections.Generic;
using AzureFunctionV2DI.Services;
using Microsoft.Azure.WebJobs.Host.Config;

namespace AzureFunctionV2DI
{
    public class InjectConfiguration : IExtensionConfigProvider
    {
        private readonly Dictionary<Type, object> _typeImplementationMap = new Dictionary<Type, object>
        {
            { typeof(ITestService), new TestService() }
        };

        public void Initialize(ExtensionConfigContext context)
        {
            context
                .AddBindingRule<InjectAttribute>()
                .BindToInput<dynamic>(i => _typeImplementationMap[i.Type]);
        }
    }
}