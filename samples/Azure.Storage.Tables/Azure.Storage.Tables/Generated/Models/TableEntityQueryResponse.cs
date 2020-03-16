// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Storage.Tables.Models
{
    /// <summary> The properties for the table entity query response. </summary>
    public partial class TableEntityQueryResponse
    {
        /// <summary> The metadata response of the table. </summary>
        public string OdataMetadata { get; internal set; }
        /// <summary> List of table entities. </summary>
        public IList<IDictionary<string, object>> Value { get; internal set; }
    }
}
