// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Information about the extracted cell in a table. </summary>
    public partial class DataTableCell
    {
        /// <summary> Row index of the cell. </summary>
        public int RowIndex { get; internal set; }
        /// <summary> Column index of the cell. </summary>
        public int ColumnIndex { get; internal set; }
        /// <summary> Number of rows spanned by this cell. </summary>
        public int? RowSpan { get; internal set; }
        /// <summary> Number of columns spanned by this cell. </summary>
        public int? ColumnSpan { get; internal set; }
        /// <summary> Text content of the cell. </summary>
        public string Text { get; internal set; }
        /// <summary> Bounding box of the cell. </summary>
        public IList<float> BoundingBox { get; internal set; } = new List<float>();
        /// <summary> Confidence value. </summary>
        public float Confidence { get; internal set; }
        /// <summary> When includeTextDetails is set to true, a list of references to the text elements constituting this table cell. </summary>
        public IList<string> Elements { get; internal set; }
        /// <summary> Is the current cell a header cell?. </summary>
        public bool? IsHeader { get; internal set; }
        /// <summary> Is the current cell a footer cell?. </summary>
        public bool? IsFooter { get; internal set; }
    }
}
