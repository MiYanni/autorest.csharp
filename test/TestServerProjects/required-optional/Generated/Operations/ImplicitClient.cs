// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace required_optional
{
    public partial class ImplicitClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal ImplicitRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ImplicitClient for mocking. </summary>
        protected ImplicitClient()
        {
        }
        /// <summary> Initializes a new instance of ImplicitClient. </summary>
        internal ImplicitClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string requiredGlobalPath, string requiredGlobalQuery, string host = "http://localhost:3000", int? optionalGlobalQuery = null)
        {
            RestClient = new ImplicitRestClient(clientDiagnostics, pipeline, requiredGlobalPath, requiredGlobalQuery, host, optionalGlobalQuery);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Test implicitly required path parameter. </summary>
        /// <param name="pathParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetRequiredPathAsync(string pathParameter, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetRequiredPathAsync(pathParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test implicitly required path parameter. </summary>
        /// <param name="pathParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetRequiredPath(string pathParameter, CancellationToken cancellationToken = default)
        {
            return RestClient.GetRequiredPath(pathParameter, cancellationToken);
        }

        /// <summary> Test implicitly optional query parameter. </summary>
        /// <param name="queryParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutOptionalQueryAsync(string queryParameter = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.PutOptionalQueryAsync(queryParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test implicitly optional query parameter. </summary>
        /// <param name="queryParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutOptionalQuery(string queryParameter = null, CancellationToken cancellationToken = default)
        {
            return RestClient.PutOptionalQuery(queryParameter, cancellationToken);
        }

        /// <summary> Test implicitly optional header parameter. </summary>
        /// <param name="queryParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutOptionalHeaderAsync(string queryParameter = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.PutOptionalHeaderAsync(queryParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test implicitly optional header parameter. </summary>
        /// <param name="queryParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutOptionalHeader(string queryParameter = null, CancellationToken cancellationToken = default)
        {
            return RestClient.PutOptionalHeader(queryParameter, cancellationToken);
        }

        /// <summary> Test implicitly optional body parameter. </summary>
        /// <param name="bodyParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutOptionalBodyAsync(string bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.PutOptionalBodyAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test implicitly optional body parameter. </summary>
        /// <param name="bodyParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutOptionalBody(string bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return RestClient.PutOptionalBody(bodyParameter, cancellationToken);
        }

        /// <summary> Test implicitly required path parameter. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetRequiredGlobalPathAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetRequiredGlobalPathAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test implicitly required path parameter. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetRequiredGlobalPath(CancellationToken cancellationToken = default)
        {
            return RestClient.GetRequiredGlobalPath(cancellationToken);
        }

        /// <summary> Test implicitly required query parameter. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetRequiredGlobalQueryAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetRequiredGlobalQueryAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test implicitly required query parameter. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetRequiredGlobalQuery(CancellationToken cancellationToken = default)
        {
            return RestClient.GetRequiredGlobalQuery(cancellationToken);
        }

        /// <summary> Test implicitly optional query parameter. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetOptionalGlobalQueryAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetOptionalGlobalQueryAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test implicitly optional query parameter. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetOptionalGlobalQuery(CancellationToken cancellationToken = default)
        {
            return RestClient.GetOptionalGlobalQuery(cancellationToken);
        }
    }
}