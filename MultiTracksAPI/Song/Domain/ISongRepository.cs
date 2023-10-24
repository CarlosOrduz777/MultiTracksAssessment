using DataAccess;
using System.Data;

namespace MultiTracksAPI.Song.Domain
{
    public interface ISongRepository
    {
        public List<DataTable> GetSongsPaged(SongPagination pagination, SQL sql);
    }
}
