using System;
using System.Collections.Generic;

public class AccountManager
{
    private Dictionary<int, User> users;
    private User loggedInUser;

    public AccountManager()
    {
        users = new Dictionary<int, User>();
    }

    public int Register(string username, string password)
    {
        return 0;
    }

    public User GetUser(int userId)
    {
        return null;
    }

    public Dictionary<int, User> GetAllUsers()
    {
        return users;
    }

    public User GetLoggedInUser()
    {
        return loggedInUser;
    }
}
