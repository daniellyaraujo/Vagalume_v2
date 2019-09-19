using Vagalume_v2.Models;

namespace Vagalume_v2.Interface
{
    public interface IVagalumeService
    {
        Music GetPassage(string passage);
        ArtistResponse GetArtist(string artist);
        Music GetSongByValues(string artist, string music);
        Music GetAlbum(string alb);
        Music GetMusic(string music);
    }
}
