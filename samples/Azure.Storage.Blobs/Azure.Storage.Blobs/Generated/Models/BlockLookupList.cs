// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> A list of block IDs split between the committed block list, in the uncommitted block list, or in the uncommitted block list first and then in the committed block list. </summary>
    public partial class BlockLookupList
    {
        /// <summary> Initializes a new instance of BlockLookupList. </summary>
        public BlockLookupList()
        {
            Committed = new ChangeTrackingList<string>();
            Uncommitted = new ChangeTrackingList<string>();
            Latest = new ChangeTrackingList<string>();
        }

        public IList<string> Committed { get; }
        public IList<string> Uncommitted { get; }
        public IList<string> Latest { get; }
    }
}