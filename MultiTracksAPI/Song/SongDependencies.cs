using MultiTracksAPI.Song.Application;
using MultiTracksAPI.Song.Domain;
using MultiTracksAPI.Song.Infrastructure;

namespace MultiTracksAPI.Song
{
    public static class SongDependencies
    {
        public static void LoadSongDependencies(this IServiceCollection services)
        {
            services.AddSingleton<ISongRepository, SongRepository>();
            services.AddSingleton<SongService>();

        }
    }
}
