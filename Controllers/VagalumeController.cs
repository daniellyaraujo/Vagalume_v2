using Microsoft.AspNetCore.Mvc;

namespace Vagalume_v2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VagalumeController : ControllerBase
    {
        public VagalumeController()
        { }

        [HttpGet("{passage}")]
        public ActionResult GetMusicByPassage(string passage)
        {
            var url = new VagalumeService("https://api.vagalume.com.br/search.excerpt?");
            var result = url.GetPassage(passage);
            return new OkObjectResult(result);
        }

        [HttpGet("{artist}")]
        public ActionResult GetArtistByValue(string artist)
        {
            var url = new VagalumeService("https://api.vagalume.com.br/search.art?");
            var result = url.GetArtist(artist);
            return new OkObjectResult(result);
        }

        [HttpGet("{artist}/{song}")]
        public ActionResult GetSongByValues(string artist, string song)
        {
            var url = new VagalumeService("https://api.vagalume.com.br/search.php?");
            var result = url.GetSong(artist, song);
            return new OkObjectResult(result);
        }

        [HttpGet]
        public ActionResult GetNewsByValue(string news)
        {
            var url = new VagalumeService("https://www.vagalume.com.br/news/index.js");
            var result = url.GetNews(news);
            return new OkObjectResult(result);
        }

    }
}
