using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCore.Data
{
    /// <summary>
    /// Stores the metadata for a youtube hyperlink
    /// </summary>
    public class TrackFootage
    {
        public string url { get; set; }

        public Track track { get; set; }
    }
}
