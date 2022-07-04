using System.ComponentModel.DataAnnotations;

namespace DadJokesServer.Models
{
    /// <summary>
    /// Model to accept login parameters
    /// </summary>
    public class LoginInfo
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
