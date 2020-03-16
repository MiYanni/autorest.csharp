// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace body_boolean
{
    public partial class BoolClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal BoolRestClient RestClient { get; }
        /// <summary> Initializes a new instance of BoolClient for mocking. </summary>
        protected BoolClient()
        {
        }
        /// <summary> Initializes a new instance of BoolClient. </summary>
        internal BoolClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new BoolRestClient(clientDiagnostics, pipeline, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Get true Boolean value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetTrueAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetTrueAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Get true Boolean value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetTrue(CancellationToken cancellationToken = default)
        {
            return RestClient.GetTrue(cancellationToken);
        }

        /// <summary> Set Boolean value true. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutTrueAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.PutTrueAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Set Boolean value true. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutTrue(CancellationToken cancellationToken = default)
        {
            return RestClient.PutTrue(cancellationToken);
        }

        /// <summary> Get false Boolean value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetFalseAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetFalseAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Get false Boolean value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetFalse(CancellationToken cancellationToken = default)
        {
            return RestClient.GetFalse(cancellationToken);
        }

        /// <summary> Set Boolean value false. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutFalseAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.PutFalseAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Set Boolean value false. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutFalse(CancellationToken cancellationToken = default)
        {
            return RestClient.PutFalse(cancellationToken);
        }

        /// <summary> Get null Boolean value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetNullAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetNullAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Get null Boolean value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetNull(CancellationToken cancellationToken = default)
        {
            return RestClient.GetNull(cancellationToken);
        }

        /// <summary> Get invalid Boolean value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetInvalidAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetInvalidAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Get invalid Boolean value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetInvalid(CancellationToken cancellationToken = default)
        {
            return RestClient.GetInvalid(cancellationToken);
        }
    }
}
