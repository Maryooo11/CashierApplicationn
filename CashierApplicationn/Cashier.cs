using System;

namespace UserAccountNamespace
{
    class Cashier : UserAccount
    {
        private string fullName;
        private string department;

        public Cashier(
            string user,
            string pass,
            string name,
            string dept)
            : base(user, pass)
        {
            fullName = name;
            department = dept;
        }

        public override bool validateLogin(
            string user,
            string pass)
        {
            return username == user &&
                   password == pass;
        }

        public string getFullName()
        {
            return fullName;
        }

        public string getDepartment()
        {
            return department;
        }
    }
}