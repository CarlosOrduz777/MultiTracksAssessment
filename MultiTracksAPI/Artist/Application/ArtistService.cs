using DataAccess;
using MultiTracksAPI.Artist.Domain;
using MultiTracksAPI.Artist.Infrastructure.Exceptions;
using System.Data;

namespace MultiTracksAPI.Artist.Application
{
    public class ArtistService
    {
        public readonly IArtistRepository _artistRepository;

        public ArtistService(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public int CreateArtist(ArtistDto artist)
        {
            if (artist == null) throw new ArtistNullException("Artist can not be null");

            if (artist.Title == null || artist.Biography == null || artist.ImageURL == null || artist.ImageURL == null)
                throw new ArtistNullPropertiesException("Some properties are null, please review it");
            return _artistRepository.PostArtist(artist);
        }

        public DataTable GetArtistByName(string artistName)
        {
            return _artistRepository.GetArtistByName(artistName);
        }
    }
}
