using Vagalume_v2.Models;

namespace Vagalume_v2.Interface
{
    public interface IVagalumeService
    {
        Music GetRelatedMusic(string music);
        Music GetExcerpt(string passage);
        ArtistResponse GetArtist(string artist);
        Music GetMusicByValues(string artist, string song);
        Music GetRelatedAlbum(string album);
    }
}
