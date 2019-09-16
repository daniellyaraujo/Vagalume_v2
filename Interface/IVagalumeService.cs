using Vagalume_v2.Models;

namespace Vagalume_v2.Interface
{
    public interface IVagalumeService
    {
        Music GetPassage(string passage);
        Music GetArtist(string artist);
        Music GetSong(string artist, string song);
        Notices GetNews(string news);
    }
}
