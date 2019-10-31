using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCore.Data
{
    /// <summary>
    /// loads track footage
    /// </summary>
    public class TrackFootageLoader : ITrackFootageLoader
    {

        public async Task<List<string>> GetTracks()
        {
            var result = new List<string>()
            {
                "cadwell",
                "blyton",
                "oulton"
            };
         

            return result;

        }
        public async Task<List<string>> GetVideos(string trackName)
        {
            var result = new List<string>();
            switch (trackName)
            {
                case "cadwell":
                    result.Add("LkO2JVFxNAw");
                    result.Add("GJlSr2SPRZg");
                    break;
                case "blyton":
                    result.Add("5N3pfcpolcI");
                    result.Add("GCnRygO9JfU");

                    break;
                default:
                    break;
            }

            return result;

        }
    }
}
