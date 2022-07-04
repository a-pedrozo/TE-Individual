namespace DadJokesServer.Models
{
    /// <summary>
    /// Model to return upon successful login
    /// </summary>
    public class NonSensitiveUser
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
    }
}
