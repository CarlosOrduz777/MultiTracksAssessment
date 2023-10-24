using DataAccess;
using MultiTracksAPI.Song.Domain;
using System.Data;

namespace MultiTracksAPI.Song.Infrastructure
{
    public class SongRepository:ISongRepository
    {


        public List<DataTable> GetSongsPaged(SongPagination pagination, SQL sql)
        {
            sql.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PageSize", pagination.PageSize));
            sql.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Page", pagination.Page));
            var result = sql.ExecuteStoredProcedureDS("GetSongsPaged", true);

            
            var records = result.Tables[0];
            var paginationInfo = result.Tables[1];

            List<DataTable> list = new List<DataTable>();
            list.Add(paginationInfo);
            list.Add(records);
            return list;
        }

    }
}
