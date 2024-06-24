namespace EF_Tutorial;

internal class Program
{
    static void Main(string[] args)
    {
        var context = new AppDbContext(); //instance of Context that we can use to make calls to the database
        var users = context.Users.ToList();
        
        foreach(var user in users)
        {
            Console.WriteLine($"{user.Firstname} {user.Lastname}");
        }
    }
}
