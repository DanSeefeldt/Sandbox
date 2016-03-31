// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.DotNet.Cli.Utils
{
    public interface ITelemetry
    {
        void TrackCommand(string command, IDictionary<string, string> properties, IDictionary<string, double> measurements);
    }
}
