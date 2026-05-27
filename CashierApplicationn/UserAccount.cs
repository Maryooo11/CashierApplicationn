using System;

namespace UserAccountNamespace
{
    abstract class UserAccount
    {
        protected string username;
        protected string password;

        public UserAccount(string user, string pass)
        {
            username = user;
            password = pass;
        }

        public abstract bool validateLogin(string user, string pass);
    }
}