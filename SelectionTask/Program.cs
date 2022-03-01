using System;

namespace SelectionTask
{
    class Program
    {
        class LoginInfo
        {
            private string username;
            private string password;
           
            public LoginInfo(string username, string password)
            {
                this.username = username;
                this.password = password;
            }
            
            public bool CheckPassword(string passwordAttempt) => passwordAttempt == password;
            public bool CheckUsername(string usernameAttempt) => usernameAttempt.ToUpper() == username.ToUpper();
            public string GetUsername() => username;

        }

        static void Main(string[] args)
        {
            LoginInfo user1 = new LoginInfo("Student", "applepie");

            Console.WriteLine("Please enter your username: ");
            if (user1.CheckUsername(Console.ReadLine()))
            {
                Console.WriteLine("Please enter your password: ");
                if (user1.CheckPassword(Console.ReadLine()))
                {
                    Console.WriteLine("login successful");
                }
                else
                {
                    Console.WriteLine("login unsuccessful");
                }
            }
            else
            {
                Console.WriteLine("login unsuccessful");
            }


        }
    }
}