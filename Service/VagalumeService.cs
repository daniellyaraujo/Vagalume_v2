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

        public Music GetRelatedMusic(string music)
        {
            var url = $"{_host}.excerpt?apikey=8225b96502a09ad6758f6c4d593b4230s&q={music}&limit=10";
            var musics = new Music();
            var musicApi = new ArtistResponse();
            try
            {
                var result = _client.GetAsync(url).Result;
                musics = result.Content.ReadAsAsync<Music>().Result;
                musicApi.Result = musics.response.Docs;
                musics.StatusCode = result.StatusCode;
            }
            catch (Exception)
            {
                musics.StatusCode = HttpStatusCode.BadGateway;
            }

            return musics;
        }

        public Music GetExcerpt(string excerpt)
        {
            string link = $"{_host}.excerpt?apiKey=8225b96502a09ad6758f6c4d593b4230s&q={excerpt}&limit=10";
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
            string link = $"{_host}.art?apiKey=660a4395f992ff67786584e238f501aa&q={artist}&limit=10";
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

        public Music GetMusicByValues(string artist, string song)
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

        public Music GetRelatedAlbum(string album)
        {
            string url = $"{_host}.alb?apikey=8225b96502a09ad6758f6c4d593b4230s&q={album}&limit=10";
            var albuns = new Music();
            try
            {
                var result = _client.GetAsync(url).Result;
                albuns = result.Content.ReadAsAsync<Music>().Result;
                albuns.StatusCode = result.StatusCode;
            }
            catch (Exception)
            {
                albuns.StatusCode = HttpStatusCode.BadGateway;
            }
            return albuns;
        }
    }
}
