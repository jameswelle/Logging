// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Extensions.Logging
{
    /// <summary>
    /// Extension methods for <see cref="AzureWebApps.AzureWebAppsLogger"/>
    /// </summary>
    public static class AzureWebAppsFactoryExtensions
    {
        /// <summary>
        /// Adds an Azure Web Apps logger. This logger is only enabled when running inside an Azure Web App
        /// </summary>
        /// <param name="factory">The extension method argument.</param>
        public static ILoggerFactory AddAzureWebApps(this ILoggerFactory factory)
        {
            return null;
            //return AddDebug(factory, LogLevel.Information);
        }
    }
}
