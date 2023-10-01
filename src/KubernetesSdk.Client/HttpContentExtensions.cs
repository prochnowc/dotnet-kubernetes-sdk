﻿using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Kubernetes.Client;

#if !NET5_0_OR_GREATER

internal static class HttpContentExtensions
{
    public static async Task<Stream> ReadAsStreamAsync(this HttpContent content, CancellationToken cancellationToken)
    {
        return await content.ReadAsStreamAsync()
                            .ConfigureAwait(false);
    }
}

#endif
