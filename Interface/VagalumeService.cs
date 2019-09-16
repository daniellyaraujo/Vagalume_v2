using System;
using System.Net;
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
            var music = result.Content.ReadAsAsync<Music>().Result;
            return music;
        }

        public Music GetArtist(string artist)
        {
            string link = $"{_host}apiKey=8225b96502a09ad6758f6c4d593b4230s&q={artist}&limit=3";
            Music result = new Music();
            try
            {
                var url = _client.GetAsync(link).Result;
                result = url.Content.ReadAsAsync<Music>().Result;
                result.StatusCode = url.StatusCode;
            }
            catch (Exception)
            {
                result.StatusCode = HttpStatusCode.BadGateway;
            }
            return result;
        }

        public Music GetSong(string artist, string song)
        {
            string url = $"{_host}art={artist}&mus={song}&extra=alb&apiKey=8225b96502a09ad6758f6c4d593b4230s";
            var result = _client.GetAsync(url).Result;
            var music = result.Content.ReadAsAsync<Music>().Result;
            return music;
        }

        public Notices GetNews(string news)
        {
            string url = _host;
            var result = _client.GetAsync(url).Result;
            var notices = result.Content.ReadAsAsync<Notices>().Result;
            return notices;
        }
    }
}
