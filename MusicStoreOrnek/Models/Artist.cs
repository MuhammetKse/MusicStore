using System.ComponentModel.DataAnnotations;

namespace MusicStoreOrnek.Models
{
    //müzik albümlerinin sanatçılarını tutacak class
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }
}
