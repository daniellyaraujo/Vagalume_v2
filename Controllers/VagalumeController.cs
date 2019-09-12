using Microsoft.AspNetCore.Mvc;
using Vagalume_v2;

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
    }
}
