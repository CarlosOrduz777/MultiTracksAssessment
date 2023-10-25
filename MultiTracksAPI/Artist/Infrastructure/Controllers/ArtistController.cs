using DataAccess;
using Microsoft.AspNetCore.Mvc;
using MTDataAccess;
using MultiTracksAPI.Artist.Application;
using MultiTracksAPI.Artist.Domain;
using System.Data;

namespace MultiTracksAPI.Artist.Infrastructure.Controllers
{
    [ApiController]
    [Route("api/artist")]
    public class ArtistController : ControllerBase
    {
        public readonly ArtistService _artistService;
        
        public ArtistController(ArtistService artistService, IConfiguration configuration)
        {
            _artistService = artistService;
        }

        /// <summary>
        /// Add new artist to Database
        /// </summary>
        /// <param name="artist"></param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("add")]
        public IActionResult Add([FromBody] ArtistDto artist)
        {
            var result = _artistService.CreateArtist(artist);
            return Ok(new
            {
                Ok = result == 1,
                ArtistAdded = result == 1 ? artist : null
            });
        }
        /// <summary>
        /// Search an artist by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetArtistByName([FromQuery] string ArtistName) 
        {
            var result = _artistService.GetArtistByName(ArtistName);
            return Ok(Newtonsoft.Json.JsonConvert.SerializeObject(result));
        }
    }
}
