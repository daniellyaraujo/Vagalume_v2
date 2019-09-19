using System;
using System.Net;
using System.Net.Http;
using Vagalume_v2.Interface;
using Vagalume_v2.Models;

namespace Vagalume_v2.Service
{
    public class VagalumeService : IVagalumeService
    {
        private readonly string _host;
        private readonly HttpClient _client;

        public VagalumeService()
        {
            _host = "https://api.vagalume.com.br/search";
            _client = new HttpClient();
        }

        public Music GetMusic(string music)
        {
            var url = $"{_host}.excerpt?apikey=8225b96502a09ad6758f6c4d593b4230s&q={music}&limit=10";
            var musics = new Music();
            try
            {
                var result = _client.GetAsync(url).Result;
                musics = result.Content.ReadAsAsync<Music>().Result;
                musics.StatusCode = result.StatusCode;
            }
            catch (Exception)
            {
                musics.StatusCode = HttpStatusCode.BadGateway;
            }

            return musics;
        }

        public Music GetPassage(string passage)
        {
            string link = $"{_host}.excerpt?apiKey=8225b96502a09ad6758f6c4d593b4230s&q={passage}&limit=10";
            var music = new Music();
            try
            {
                var result = _client.GetAsync(link).Result;
                music = result.Content.ReadAsAsync<Music>().Result;
                music.StatusCode = result.StatusCode;
            }
            catch (Exception)
            {
                music.StatusCode = HttpStatusCode.BadGateway;
            }
            return music;
        }

        public ArtistResponse GetArtist(string artist)
        {
            string link = $"{_host}.art?apiKey=8225b96502a09ad6758f6c4d593b4230s&q={artist}&limit=10";
            var music = new Music();
            var musicApi = new ArtistResponse();

            try
            {
                var result = _client.GetAsync(link).Result;
                music = result.Content.ReadAsAsync<Music>().Result;
                musicApi.Result = music.response.Docs;
                musicApi.StatusCode = result.StatusCode;
            }
            catch (Exception)
            {
                musicApi.StatusCode = HttpStatusCode.BadGateway;
            }
            return musicApi;
        }

        public Music GetSongByValues(string artist, string song)
        {
            string url = $"{_host}.php?art={artist}&mus={song}&extra=alb&apiKey=8225b96502a09ad6758f6c4d593b4230s";
            var music = new Music();
            try
            {
                var result = _client.GetAsync(url).Result;
                music = result.Content.ReadAsAsync<Music>().Result;
                music.StatusCode = result.StatusCode;
            }
            catch (Exception)
            {
                music.StatusCode = HttpStatusCode.BadGateway;
            }
            return music;
        }

        public Music GetAlbum(string alb)
        {
            string url = $"{_host}.alb?apikey=8225b96502a09ad6758f6c4d593b4230s&q={alb}18%20Singles&limit=10";
            var album = new Music();
            try
            {
                var result = _client.GetAsync(url).Result;
                album = result.Content.ReadAsAsync<Music>().Result;
                album.StatusCode = result.StatusCode;
            }
            catch (Exception)
            {
                album.StatusCode = HttpStatusCode.BadGateway;
            }
            return album;
        }
    }
}
