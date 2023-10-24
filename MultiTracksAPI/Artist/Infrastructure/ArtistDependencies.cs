using MultiTracksAPI.Artist.Application;
using MultiTracksAPI.Artist.Domain;
using MultiTracksAPI.Artist.Infrastructure.Repositories;

namespace MultiTracksAPI.Artist.Infrastructure
{
    public static class ArtistDependencies
    {
        public static void LoadArtistDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IArtistRepository, ArtistRepository>();
            services.AddSingleton<ArtistService>();
        }
    }
}
