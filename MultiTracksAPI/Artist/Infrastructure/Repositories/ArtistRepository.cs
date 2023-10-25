using DataAccess;
using MultiTracksAPI.Artist.Infrastructure.Exceptions;
using MultiTracksAPI.Artist.Domain;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using MTDataAccess;

namespace MultiTracksAPI.Artist.Infrastructure.Repositories
{
    public class ArtistRepository:IArtistRepository
    {
        private readonly IConfiguration _configuration;
        private SQL _sql;

        public ArtistRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _sql = new ApiSql(_configuration.GetConnectionString("admin"));
        }

        public int PostArtist(ArtistDto artist)
        {
            _sql.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Title", artist.Title));
            _sql.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Biography", artist.Biography));
            _sql.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ImageURL", artist.ImageURL));
            _sql.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HeroURL", artist.HeroURL));

            var result = _sql.ExecuteStoredProcedure("CreateArtist",true);
            return result;
        }

        public DataTable GetArtistByName(string artistName)
        {
            _sql.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", artistName));
            var result = _sql.ExecuteStoredProcedureDT("GetArtistByName", true);
            return result;
        }
   
    }
}
