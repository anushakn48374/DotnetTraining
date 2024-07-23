using SingleResponsibility;

class Program
{
    static void Main(string[] args)
    {
        UserProfile userProfile = new UserProfile
        {
            Name = "Alice",
            Email = "alice@example.com"
        };


        userProfile.DisplayProfile();
    }
}