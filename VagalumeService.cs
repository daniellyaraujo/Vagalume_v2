using System.Net.Http;
using Vagalume_v2.Interface;
using Vagalume_v2.Models;

namespace Vagalume_v2
{
    public class VagalumeService : IVagalumeService
    {
        private string _host;
        private readonly HttpClient _client;

        public VagalumeService(string host)
        {
            _host = host;
            _client = new HttpClient();
        }

        public Music GetPassage(string passage)
        {
            string link = $"{_host}apiKey=8225b96502a09ad6758f6c4d593b4230s&q={passage}&limit=6";
            var result = _client.GetAsync(link).Result;
            var musicRelated = result.Content.ReadAsAsync<Music>().Result;
            return musicRelated;
        }

        public Music GetArtist(string artist)
        {
            string link = $"{_host}apiKey=8225b96502a09ad6758f6c4d593b4230s&q={artist}&limit=3";
            var result = _client.GetAsync(link).Result;
            var artistRelated = result.Content.ReadAsAsync<Music>().Result;
            return artistRelated;
        }


    }
}
