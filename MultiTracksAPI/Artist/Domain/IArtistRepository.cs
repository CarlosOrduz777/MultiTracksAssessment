using DataAccess;
using System.Data;

namespace MultiTracksAPI.Artist.Domain
{
    public interface IArtistRepository
    {
        int PostArtist(ArtistDto artist);
        DataTable GetArtistByName(string artistName);
    }
}
