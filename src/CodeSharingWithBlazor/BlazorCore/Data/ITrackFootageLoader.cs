using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCore.Data
{
    public interface ITrackFootageLoader
    {
        Task<List<string>> GetVideos(string trackName);

        Task<List<string>> GetTracks();
    }
}
