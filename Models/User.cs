using System.ComponentModel.DataAnnotations;

namespace TestWebApp.Models
{
    public class User
    {
        public int UserId { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }
    }
}
