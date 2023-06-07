using System.ComponentModel.DataAnnotations;

namespace MusicStoreOrnek.Models
{
    public class Genre
    {
        //prop tab tab tuşuna basarak
        //public int Id { get; set; }
        //public string Name { get; set; }
     
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }


    }
}
