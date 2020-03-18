// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using validation.Models;

namespace validation
{
    public partial class ServiceClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal ServiceRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ServiceClient for mocking. </summary>
        protected ServiceClient()
        {
        }
        /// <summary> Initializes a new instance of ServiceClient. </summary>
        internal ServiceClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "http://localhost:3000", string apiVersion = "1.0.0")
        {
            RestClient = new ServiceRestClient(clientDiagnostics, pipeline, subscriptionId, host, apiVersion);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Validates input parameters on the method. See swagger for details. </summary>
        /// <param name="resourceGroupName"> Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+. </param>
        /// <param name="id"> Required int multiple of 10 from 100 to 1000. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Product>> ValidationOfMethodParametersAsync(string resourceGroupName, int id, CancellationToken cancellationToken = default)
        {
            return await RestClient.ValidationOfMethodParametersAsync(resourceGroupName, id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Validates input parameters on the method. See swagger for details. </summary>
        /// <param name="resourceGroupName"> Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+. </param>
        /// <param name="id"> Required int multiple of 10 from 100 to 1000. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Product> ValidationOfMethodParameters(string resourceGroupName, int id, CancellationToken cancellationToken = default)
        {
            return RestClient.ValidationOfMethodParameters(resourceGroupName, id, cancellationToken);
        }

        /// <summary> Validates body parameters on the method. See swagger for details. </summary>
        /// <param name="resourceGroupName"> Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+. </param>
        /// <param name="id"> Required int multiple of 10 from 100 to 1000. </param>
        /// <param name="body"> The Product to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Product>> ValidationOfBodyAsync(string resourceGroupName, int id, Product body, CancellationToken cancellationToken = default)
        {
            return await RestClient.ValidationOfBodyAsync(resourceGroupName, id, body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Validates body parameters on the method. See swagger for details. </summary>
        /// <param name="resourceGroupName"> Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+. </param>
        /// <param name="id"> Required int multiple of 10 from 100 to 1000. </param>
        /// <param name="body"> The Product to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Product> ValidationOfBody(string resourceGroupName, int id, Product body, CancellationToken cancellationToken = default)
        {
            return RestClient.ValidationOfBody(resourceGroupName, id, body, cancellationToken);
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetWithConstantInPathAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetWithConstantInPathAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetWithConstantInPath(CancellationToken cancellationToken = default)
        {
            return RestClient.GetWithConstantInPath(cancellationToken);
        }

        /// <param name="body"> The Product to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Product>> PostWithConstantInBodyAsync(Product body, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostWithConstantInBodyAsync(body, cancellationToken).ConfigureAwait(false);
        }

        /// <param name="body"> The Product to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Product> PostWithConstantInBody(Product body, CancellationToken cancellationToken = default)
        {
            return RestClient.PostWithConstantInBody(body, cancellationToken);
        }
    }
}
