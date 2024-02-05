using System.ComponentModel.DataAnnotations;

namespace E_TicaretSitesi.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Email{ get; set; }
        public string Password{ get; set; }
    }
}
