﻿using System;
using System.Collections.Generic;

namespace Logic
{
    public class UsersManager
    {
        public List<User> Users { get; set;}
        public UsersManager()
        {
            Users = new List<User>()
            {
                new User () {Name = "Edwin"},
                new User () {Name = "Daniel"}
            };
        }
        public List<User> GetUsers()
        {
            return Users;
        }
        public User PostUsers(User user)
        {
            Users.Add(user);
            return user;
        }
        public User PutUsers(User user)
        {
            Users.Find
        }
        public User DeleteUsers(User user)
        {
            //return true;
        }
    }
}
