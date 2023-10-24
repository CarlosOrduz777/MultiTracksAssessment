using DataAccess;
using System.Data;

namespace MultiTracksAPI.Artist.Domain
{
    public interface IArtistRepository
    {
        int PostArtist(ArtistDto artist,SQL sql);
        DataTable GetArtistByName(string artistName,SQL sql);
    }
}
