// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace httpInfrastructure.quirks
{
    internal partial class HttpSuccessOperations
    {
        private string host;
        private ClientDiagnostics clientDiagnostics;
        private HttpPipeline pipeline;
        /// <summary> Initializes a new instance of HttpSuccessOperations. </summary>
        public HttpSuccessOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }

            this.host = host;
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        internal HttpMessage CreateHead200Request()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Head;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/200", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Return 200 status code if successful. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Head200Async(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Head200");
            scope.Start();
            try
            {
                using var message = CreateHead200Request();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Return 200 status code if successful. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Head200(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Head200");
            scope.Start();
            try
            {
                using var message = CreateHead200Request();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateGet200Request()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/200", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Get 200 success. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<bool>> Get200Async(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Get200");
            scope.Start();
            try
            {
                using var message = CreateGet200Request();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = document.RootElement.GetBoolean();
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Get 200 success. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<bool> Get200(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Get200");
            scope.Start();
            try
            {
                using var message = CreateGet200Request();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = document.RootElement.GetBoolean();
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateOptions200Request()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/200", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Options 200 success. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<bool>> Options200Async(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Options200");
            scope.Start();
            try
            {
                using var message = CreateOptions200Request();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = document.RootElement.GetBoolean();
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Options 200 success. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<bool> Options200(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Options200");
            scope.Start();
            try
            {
                using var message = CreateOptions200Request();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = document.RootElement.GetBoolean();
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePut200Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/200", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Put boolean value true returning 200 success. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Put200Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Put200");
            scope.Start();
            try
            {
                using var message = CreatePut200Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Put boolean value true returning 200 success. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Put200(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Put200");
            scope.Start();
            try
            {
                using var message = CreatePut200Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePatch200Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/200", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Patch true Boolean value in request returning 200. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Patch200Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Patch200");
            scope.Start();
            try
            {
                using var message = CreatePatch200Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Patch true Boolean value in request returning 200. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Patch200(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Patch200");
            scope.Start();
            try
            {
                using var message = CreatePatch200Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePost200Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/200", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Post bollean value true in request that returns a 200. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Post200Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Post200");
            scope.Start();
            try
            {
                using var message = CreatePost200Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Post bollean value true in request that returns a 200. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Post200(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Post200");
            scope.Start();
            try
            {
                using var message = CreatePost200Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateDelete200Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/200", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Delete simple boolean value true returns 200. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Delete200Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Delete200");
            scope.Start();
            try
            {
                using var message = CreateDelete200Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Delete simple boolean value true returns 200. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete200(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Delete200");
            scope.Start();
            try
            {
                using var message = CreateDelete200Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePut201Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/201", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Put true Boolean value in request returns 201. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Put201Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Put201");
            scope.Start();
            try
            {
                using var message = CreatePut201Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 201:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Put true Boolean value in request returns 201. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Put201(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Put201");
            scope.Start();
            try
            {
                using var message = CreatePut201Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 201:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePost201Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/201", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Post true Boolean value in request returns 201 (Created). </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Post201Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Post201");
            scope.Start();
            try
            {
                using var message = CreatePost201Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 201:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Post true Boolean value in request returns 201 (Created). </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Post201(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Post201");
            scope.Start();
            try
            {
                using var message = CreatePost201Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 201:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePut202Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/202", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Put true Boolean value in request returns 202 (Accepted). </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Put202Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Put202");
            scope.Start();
            try
            {
                using var message = CreatePut202Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Put true Boolean value in request returns 202 (Accepted). </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Put202(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Put202");
            scope.Start();
            try
            {
                using var message = CreatePut202Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePatch202Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/202", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Patch true Boolean value in request returns 202. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Patch202Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Patch202");
            scope.Start();
            try
            {
                using var message = CreatePatch202Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Patch true Boolean value in request returns 202. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Patch202(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Patch202");
            scope.Start();
            try
            {
                using var message = CreatePatch202Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePost202Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/202", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Post true Boolean value in request returns 202 (Accepted). </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Post202Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Post202");
            scope.Start();
            try
            {
                using var message = CreatePost202Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Post true Boolean value in request returns 202 (Accepted). </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Post202(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Post202");
            scope.Start();
            try
            {
                using var message = CreatePost202Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateDelete202Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/202", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Delete true Boolean value in request returns 202 (accepted). </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Delete202Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Delete202");
            scope.Start();
            try
            {
                using var message = CreateDelete202Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Delete true Boolean value in request returns 202 (accepted). </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete202(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Delete202");
            scope.Start();
            try
            {
                using var message = CreateDelete202Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateHead204Request()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Head;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/204", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Return 204 status code if successful. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Head204Async(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Head204");
            scope.Start();
            try
            {
                using var message = CreateHead204Request();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Return 204 status code if successful. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Head204(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Head204");
            scope.Start();
            try
            {
                using var message = CreateHead204Request();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePut204Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/204", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Put true Boolean value in request returns 204 (no content). </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Put204Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Put204");
            scope.Start();
            try
            {
                using var message = CreatePut204Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Put true Boolean value in request returns 204 (no content). </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Put204(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Put204");
            scope.Start();
            try
            {
                using var message = CreatePut204Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePatch204Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/204", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Patch true Boolean value in request returns 204 (no content). </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Patch204Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Patch204");
            scope.Start();
            try
            {
                using var message = CreatePatch204Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Patch true Boolean value in request returns 204 (no content). </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Patch204(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Patch204");
            scope.Start();
            try
            {
                using var message = CreatePatch204Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePost204Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/204", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Post true Boolean value in request returns 204 (no content). </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Post204Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Post204");
            scope.Start();
            try
            {
                using var message = CreatePost204Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Post true Boolean value in request returns 204 (no content). </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Post204(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Post204");
            scope.Start();
            try
            {
                using var message = CreatePost204Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateDelete204Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/204", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Delete true Boolean value in request returns 204 (no content). </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Delete204Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Delete204");
            scope.Start();
            try
            {
                using var message = CreateDelete204Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Delete true Boolean value in request returns 204 (no content). </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete204(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Delete204");
            scope.Start();
            try
            {
                using var message = CreateDelete204Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateHead404Request()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Head;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/success/404", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Return 404 status code. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Head404Async(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Head404");
            scope.Start();
            try
            {
                using var message = CreateHead404Request();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Return 404 status code. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Head404(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpSuccessOperations.Head404");
            scope.Start();
            try
            {
                using var message = CreateHead404Request();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}