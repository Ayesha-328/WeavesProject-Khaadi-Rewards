public class RegisterUserRequest
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; } // store_admin or super_admin
}
