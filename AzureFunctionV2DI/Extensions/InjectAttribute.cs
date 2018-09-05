using System;
using Microsoft.Azure.WebJobs.Description;

namespace AzureFunctionV2DI.Extensions
{
    /// <summary>
    /// Function parameter that will be resolved using <see cref="InjectConfiguration"/>
    /// </summary>
    [Binding]
    [AttributeUsage(AttributeTargets.Parameter)]
    public class InjectAttribute : Attribute
    {
        public InjectAttribute(Type type)
        {
            Type = type;
        }

        public Type Type { get; }
    }
}