namespace DadJokesServer.Security
{
    public interface IPasswordHasher
    {
        PasswordHash ComputeHash(string plainTextPassword);
        bool VerifyHashMatch(string existingHashedPassword, string plainTextPassword, string salt);
    }
}