using MusicStore.Models;
using System.Collections.Generic;

namespace MusicStore.ViewModels
{
    public class ArtistViewModel
    {
        public List<Album> Album { get; set; }
        public List<Artist> Artist { get; set; }
    }
}
