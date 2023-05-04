using System.ComponentModel.DataAnnotations;

namespace eTicketss.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //RELATIONSHIPS

        public List<Movie> Movies { get; set; }
    }
}
