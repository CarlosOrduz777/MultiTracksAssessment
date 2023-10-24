using DataAccess;
using MultiTracksAPI.Song.Domain;
using System.Data;

namespace MultiTracksAPI.Song.Application
{
    public class SongService
    {
        private readonly ISongRepository _songRepository;

        public SongService(ISongRepository songRepository)
        {
            _songRepository = songRepository;
        }

        public List<DataTable> GetSongsPaged(SongPagination pagination, SQL sql)
        {
            if(pagination == null) throw new ArgumentNullException("Pagination object cannot be null");
            return _songRepository.GetSongsPaged(pagination, sql);
        }
    }
}
