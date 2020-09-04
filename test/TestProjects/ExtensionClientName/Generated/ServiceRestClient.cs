// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using ExtensionClientName.Models;

namespace ExtensionClientName
{
    internal partial class ServiceRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ServiceRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public ServiceRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("http://localhost:3000");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateRenamedOperationRequest(string renamedPathParameter, string renamedQueryParameter, RenamedSchema renamedBodyParameter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/originalOperation/", false);
            uri.AppendPath(renamedPathParameter, true);
            uri.AppendQuery("originalQueryParameter", renamedQueryParameter, true);
            request.Uri = uri;
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(renamedBodyParameter);
            request.Content = content;
            return message;
        }

        /// <param name="renamedPathParameter"> The String to use. </param>
        /// <param name="renamedQueryParameter"> The String to use. </param>
        /// <param name="renamedBodyParameter"> The RenamedSchema to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="renamedPathParameter"/>, <paramref name="renamedQueryParameter"/>, or <paramref name="renamedBodyParameter"/> is null. </exception>
        public async Task<ResponseWithHeaders<RenamedSchema, ServiceRenamedOperationHeaders>> RenamedOperationAsync(string renamedPathParameter, string renamedQueryParameter, RenamedSchema renamedBodyParameter, CancellationToken cancellationToken = default)
        {
            if (renamedPathParameter == null)
            {
                throw new ArgumentNullException(nameof(renamedPathParameter));
            }
            if (renamedQueryParameter == null)
            {
                throw new ArgumentNullException(nameof(renamedQueryParameter));
            }
            if (renamedBodyParameter == null)
            {
                throw new ArgumentNullException(nameof(renamedBodyParameter));
            }

            using var message = CreateRenamedOperationRequest(renamedPathParameter, renamedQueryParameter, renamedBodyParameter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ServiceRenamedOperationHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RenamedSchema value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RenamedSchema.DeserializeRenamedSchema(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="renamedPathParameter"> The String to use. </param>
        /// <param name="renamedQueryParameter"> The String to use. </param>
        /// <param name="renamedBodyParameter"> The RenamedSchema to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="renamedPathParameter"/>, <paramref name="renamedQueryParameter"/>, or <paramref name="renamedBodyParameter"/> is null. </exception>
        public ResponseWithHeaders<RenamedSchema, ServiceRenamedOperationHeaders> RenamedOperation(string renamedPathParameter, string renamedQueryParameter, RenamedSchema renamedBodyParameter, CancellationToken cancellationToken = default)
        {
            if (renamedPathParameter == null)
            {
                throw new ArgumentNullException(nameof(renamedPathParameter));
            }
            if (renamedQueryParameter == null)
            {
                throw new ArgumentNullException(nameof(renamedQueryParameter));
            }
            if (renamedBodyParameter == null)
            {
                throw new ArgumentNullException(nameof(renamedBodyParameter));
            }

            using var message = CreateRenamedOperationRequest(renamedPathParameter, renamedQueryParameter, renamedBodyParameter);
            _pipeline.Send(message, cancellationToken);
            var headers = new ServiceRenamedOperationHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RenamedSchema value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RenamedSchema.DeserializeRenamedSchema(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
