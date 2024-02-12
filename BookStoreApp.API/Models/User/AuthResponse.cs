namespace BookStoreApp.API.Models.User
{
    // The DTO class that is used insede AuthController.cs
    public class AuthResponse
    {
        public string UserId { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }

    }
}
