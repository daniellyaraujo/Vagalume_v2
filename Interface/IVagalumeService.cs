using Vagalume_v2.Models;

namespace Vagalume_v2.Interface
{
    public interface IVagalumeService
    {
        Music GetRelatedMusic(string music);
        Music GetPassage(string passage);
        ArtistResponse GetArtist(string artist);
        Music GetMusicByValues(string artist, string song);
        Music GetRelatedAlbum(string album);
    }
}
