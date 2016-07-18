// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.Extensions.Logging.AzureWebApps
{
    /// <summary>
    /// Represents an Azure Web apps logger
    /// </summary>
    public class AzureWebAppsLogger : ILogger
    {
        /// <inheritdoc />
        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool IsEnabled(LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            throw new NotImplementedException();
        }
    }
}
