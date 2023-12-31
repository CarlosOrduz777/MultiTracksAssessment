﻿using DataAccess;
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
        public SongController(SongService songService)
        {
            _songService = songService;
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IActionResult GetSongsList([FromQuery] SongPagination pagination)
        {
            var PaginationAndRecordDataTables = _songService.GetSongsPaged(pagination);
            if (PaginationAndRecordDataTables == null) return StatusCode(500);
            var paginationInfo = PaginationAndRecordDataTables.ElementAt(0);
            var records = PaginationAndRecordDataTables.ElementAt(1);
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
