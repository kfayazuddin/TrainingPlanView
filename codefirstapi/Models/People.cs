using System.ComponentModel.DataAnnotations;

namespace codefirstapi.Models
{
    public class People { 


        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
