using System;
using System.Collections.Generic;

public class UserManager
{
    private List<User> _users;

    public UserManager()
    {
        _users = new List<User>();
    }

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public User GetUserByUsername(string username)
    {
        return _users.Find(u => u.GetUsername() == username);
    }
}