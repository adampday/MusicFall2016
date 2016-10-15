using System.ComponentModel.DataAnnotations;

namespace MusicFall2016.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        [Display(Name="Genre")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
    }
}