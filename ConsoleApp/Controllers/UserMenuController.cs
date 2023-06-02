using ConsoleMenu;
using ConsoleMenu.Builder;
using StoreDAL.Data;
using StoreDAL.Data.InitDataFactory;

namespace ConsoleApp1;

public enum UserRoles
{
    Guest,
    Administrator,
    RegistredCustomer
}

public static class UserMenuController
{
    private static readonly Dictionary<UserRoles, Menu> rolesToMenu;
    private static int userId;
    private static UserRoles userRole;
    private static StoreDbContext context;

    static UserMenuController()
    {
        userId = 0;
        userRole = UserRoles.Guest;
        rolesToMenu = new Dictionary<UserRoles, Menu>();
        var factory = new StoreDbFactory(new TestDataFactory());
        context = factory.CreateContext();
        rolesToMenu.Add(UserRoles.Guest, new GuestMainMenu().Create(context));
        rolesToMenu.Add(UserRoles.RegistredCustomer, new UserMainMenu().Create(context));
        rolesToMenu.Add(UserRoles.Administrator, new AdminMainMenu().Create(context));
    }

    public static StoreDbContext Context
    { 
        get { return context; } 
    }
    public static void Login()
    {
        Console.WriteLine("Login: ");
        var login =Console.ReadLine();
        Console.WriteLine("Password: ");
        var password = Console.ReadLine();
        if(login=="admin")
        {
            userId = 1;
            userRole = UserRoles.Administrator;
        }
        if(login=="user")
        {
            userId= 1;
            userRole = UserRoles.RegistredCustomer;
        }
        //ToDo

    }

    public static void Logout()
    {
        userId = 0;
        userRole = UserRoles.Guest;
    }

    public static void Start()
    {
        ConsoleKey resKey;
        bool updateItems = true;
        do
        {
            //rolesToMenu[userRole].Run();
            resKey = rolesToMenu[userRole].RunOnce(ref updateItems);
        } while (resKey != ConsoleKey.Escape);


    }
}

