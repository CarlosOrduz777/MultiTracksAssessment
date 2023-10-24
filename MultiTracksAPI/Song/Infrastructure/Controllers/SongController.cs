using DataAccess;
using Microsoft.AspNetCore.Mvc;
using MTDataAccess;
using MultiTracksAPI.Song.Application;
using MultiTracksAPI.Song.Domain;
using System.Web.Http;
using System.Web.Http.Results;

namespace MultiTracksAPI.Song.Infrastructure.Controllers
{

    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/song")]
    public class SongController : Controller
    {
        private readonly SongService _songService;
        private SQL _sql;
        private readonly IConfiguration _configuration;
        public SongController(SongService songService, IConfiguration configuration)
        {
            _songService = songService;
            _configuration = configuration;
            _sql = new ApiSql(_configuration.GetConnectionString("admin"));
            
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IActionResult GetSongsList([FromQuery] SongPagination pagination)
        {
            var result = _songService.GetSongsPaged(pagination, _sql);
            if (result == null) return StatusCode(500);
            var paginationInfo = result.ElementAt(0);
            var records = result.ElementAt(1);
            var ObjectResult = new
            {
                paginationInfo = new
                {
                    Pages = paginationInfo.Rows[0]["Pages"],
                    TotalRecords = paginationInfo.Rows[0]["TotalRecords"],
                    CurrentPage = pagination.Page,
                    RecordsPerPage = pagination.PageSize
                },
                data = records
            };
            return Ok(Newtonsoft.Json.JsonConvert.SerializeObject(ObjectResult));
        }
    }
}
