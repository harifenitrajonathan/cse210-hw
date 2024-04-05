using System;
using System.Collections.Generic;

public class AccountManager
{
    private List<User> _users;
    private User _currentUser;

    public AccountManager()
    {
        _users = new List<User>();
    }

    public void Register(string username, string password)
    {
        var user = new User(_users.Count + 1, username, password);
        _users.Add(user);
        _currentUser = user;
    }

    public User GetCurrentUser()
    {
        return _currentUser;
    }
}