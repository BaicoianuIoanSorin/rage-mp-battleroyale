using System.ComponentModel.DataAnnotations;

namespace mygamemode.EFCore.model
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}