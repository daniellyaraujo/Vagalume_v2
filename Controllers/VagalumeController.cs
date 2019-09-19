using Microsoft.AspNetCore.Mvc;
using Vagalume_v2.Interface;
using Vagalume_v2.Models;
using Vagalume_v2.Service;

namespace Vagalume_v2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class VagalumeController : ControllerBase
    {
        IVagalumeService _service;

        public VagalumeController()
        {
            _service = new VagalumeService();
        }

        [HttpGet("music/{music}")]
        public ActionResult GetMusicByName(string music)
        {
            var result = _service.GetMusic(music);
            switch (result.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    return new OkObjectResult(result);
                default:
                    return new StatusCodeResult((int)result.StatusCode);
            }
        }

        [HttpGet("passage/{passage}")]
        public ActionResult GetMusicByPassage(string passage)
        {
            var result = _service.GetPassage(passage);
            switch (result.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    return new OkObjectResult(result);
                default:
                    return new StatusCodeResult((int)result.StatusCode);
            }
        }

        [HttpGet("artist/{artist}")]
        public ActionResult GetArtistByName(string artist)
        {
            var result = _service.GetArtist(artist);
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var messageResponse = new MessageResponse();

                if (result.Result.Count == 0)
                {
                    messageResponse.Mensagem = "Artista não localizado";
                    return new BadRequestObjectResult(messageResponse);
                }
            }
            else
                return new StatusCodeResult((int)result.StatusCode);

            return new OkObjectResult(result);
        }

        [HttpGet("album/{alb}")]
        public ActionResult GetAlbByName(string album)
        {
            var result = _service.GetAlbum(album);
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var messageResponse = new MessageResponse();
                if (result.response.Docs.Count == 0)
                {
                    messageResponse.Mensagem = "Album não localizado";
                    return new BadRequestObjectResult(messageResponse);
                }
            }
            else
                return new StatusCodeResult((int)result.StatusCode);

            return new OkObjectResult(result);
        }

        [HttpGet("exmusic/{artist}/{music}")]
        public ActionResult GetSongByValues(string artist, string music)
        {
            var result = _service.GetMusicByValues(artist, music);
            switch (result.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    return new OkObjectResult(result);
                default:
                    return new StatusCodeResult((int)result.StatusCode);
            }
        }
    }
}
