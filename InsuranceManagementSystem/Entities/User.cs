namespace InsuranceManagementSystem.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string U_Password { get; set; }
        public string U_Role { get; set; }

        public User() { }
        public User(int userId, string username, string password, string role)
        {
            UserId = userId;
            Username = username;
            U_Password = password;
            U_Role = role;
        }
        public void PrintUserDetails()
        {
            Console.WriteLine($"UserId: {UserId}, Username: {Username}, Role: {U_Role}");
        }
    }
}
