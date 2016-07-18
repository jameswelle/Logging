// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.Extensions.Logging.AzureWebApps
{
    /// <summary>
    /// The provider for <see cref="AzureWebAppsLogger"/>
    /// </summary>
    public class AzureWebAppsLoggerProvider : ILoggerProvider
    {
        /// <inheritdoc />
        public ILogger CreateLogger(string categoryName)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Dispose()
        {
        }
    }
}
