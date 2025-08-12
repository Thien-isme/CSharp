namespace healthcareProject.Models.Response
{
    public class LoginUserResponse
    {
        public string Success { get; set; } = "true";
        public string Message { get; set; } = "Login successful";

        public int UserId { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }
}
