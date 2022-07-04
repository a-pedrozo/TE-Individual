namespace DadabaseApp.Models
{
    /// <summary>
    /// Model to return upon successful login.
    /// This does NOT contain any sensitive information such as salt or hash.
    /// </summary>
    public class UserInfo
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
    }
}
