// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace NetworkInterface.Models
{
    /// <summary> Url configuration of the Actions set in Application Gateway. </summary>
    public partial class ApplicationGatewayUrlConfiguration
    {
        /// <summary> Url path which user has provided for url rewrite. Null means no path will be updated. Default value is null. </summary>
        public string ModifiedPath { get; set; }
        /// <summary> Query string which user has provided for url rewrite. Null means no query string will be updated. Default value is null. </summary>
        public string ModifiedQueryString { get; set; }
        /// <summary> If set as true, it will re-evaluate the url path map provided in path based request routing rules using modified path. Default value is false. </summary>
        public bool? Reroute { get; set; }
    }
}
