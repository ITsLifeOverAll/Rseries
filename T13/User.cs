namespace T13;

public class User
{
    public string Name { get; set; }
    public string Password { get; set; }  
}

public class UserManager
{
    public bool Login(User user, string inputPassword)
    {
        return user.Password == inputPassword;
    }

    public void ResetPassword(User user, string newPassword)
    {
        user.Password = newPassword;
    }
}
