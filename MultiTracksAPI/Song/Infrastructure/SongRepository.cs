using DataAccess;
using MTDataAccess;
using MultiTracksAPI.Song.Domain;
using System.Data;

namespace MultiTracksAPI.Song.Infrastructure
{
    public class SongRepository:ISongRepository
    {

        private readonly IConfiguration _configuration;
        private SQL _sql;

        public SongRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _sql = new ApiSql(_configuration.GetConnectionString("admin"));
        }

        public List<DataTable> GetSongsPaged(SongPagination pagination)
        {
            _sql.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PageSize", pagination.PageSize));
            _sql.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Page", pagination.Page));
            var result = _sql.ExecuteStoredProcedureDS("GetSongsPaged", true);

            
            var records = result.Tables[0];
            var paginationInfo = result.Tables[1];

            List<DataTable> list = new List<DataTable>();
            list.Add(paginationInfo);
            list.Add(records);
            return list;
        }

    }
}
