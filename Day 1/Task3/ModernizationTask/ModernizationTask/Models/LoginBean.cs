using System.ComponentModel.DataAnnotations;

namespace ModernizationTask.Models
{
    public class LoginBean
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
