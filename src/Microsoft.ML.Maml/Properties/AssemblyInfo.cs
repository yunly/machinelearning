// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.CompilerServices;
using Microsoft.ML;

[assembly: InternalsVisibleTo("Microsoft.ML.TestFramework" + PublicKey.TestValue)]
[assembly: InternalsVisibleTo("Microsoft.ML.Benchmarks" + PublicKey.TestValue)]

[assembly: InternalsVisibleTo("Microsoft.ML.Legacy" + PublicKey.Value)]
[assembly: InternalsVisibleTo("Microsoft.ML.ResultProcessor" + PublicKey.Value)]
