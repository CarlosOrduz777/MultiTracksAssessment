using DataAccess;
using MultiTracksAPI.Artist.Infrastructure.Exceptions;
using MultiTracksAPI.Artist.Domain;
using System.Data;
using Microsoft.AspNetCore.Mvc;

namespace MultiTracksAPI.Artist.Infrastructure.Repositories
{
    public class ArtistRepository:IArtistRepository
    {
      
        public int PostArtist(ArtistDto artist, SQL sql)
        {
            sql.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Title", artist.Title));
            sql.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Biography", artist.Biography));
            sql.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ImageURL", artist.ImageURL));
            sql.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HeroURL", artist.HeroURL));

            var result = sql.ExecuteStoredProcedure("CreateArtist",true);
            return result;
        }

        public DataTable GetArtistByName(string artistName, SQL sql)
        {
            sql.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", artistName));
            var result = sql.ExecuteStoredProcedureDT("GetArtistByName", true);
            return result;
        }
   
    }
}
