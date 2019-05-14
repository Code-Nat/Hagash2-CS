using System;

namespace Hagsha2CS
{
    class User_Mangment
    {
        static string Print (string message)
        {
            Console.WriteLine(message);
            try
            {
                return Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return "";
            }
        }
        static void Main()
        {
            User user1 = new User();

            user1.Username = Print("Please enter your new username: (" + user1.UsernameSpecs + ")");
            while (user1.Username == "")
                user1.Username = Print("What you entered is invalid, please enter your new username: (" + user1.UsernameSpecs + ")");

            user1.Password = Print("Please enter your new password: (" + user1.PasswordSpecs + ")");
            while (user1.Password == "")
                user1.Password = Print("What you entered is invalid, please enter your new password: (" + user1.PasswordSpecs + ")");

            Console.Clear();

            for (int i = 0; i < user1.Username.Length+22; i++)
                Console.Write("-");
            Console.WriteLine("");
            Console.WriteLine("your username is | " + user1.Username + " |");
            for (int i = 0; i < user1.Username.Length + 22; i++)
                Console.Write("-");
            Console.WriteLine("");

            for (int i = 0; i < user1.Password.Length + 22; i++)
                Console.Write("-");
            Console.WriteLine("");
            Console.WriteLine("your password is: | " + user1.Password + " |");
            for (int i = 0; i < user1.Password.Length + 22; i++)
                Console.Write("-");
            Console.WriteLine("");

            Console.ReadLine();
        }
    }

    class User
    {
        private string username = "";
        private string password = "";

        public string Username
        {
            set
            {
                if (value.Length >= 3 && value.Length <= 64)
                    username = value;
                else
                    username = "";
            }

            get
            {
                return username;
            }
        }

        public string UsernameSpecs
        {
            get { return "3 to 46 letters"; }
        }

    public string Password
        {
            set
            {
                if (value.Length >= 8 && value.Length <= 128)
                {
                    bool oneNum = false, oneUpper = false, oneLower = false;
                    foreach (char cha in value)
                        if (!oneUpper || char.IsUpper(cha))
                            oneUpper = true;
                        else if (!oneLower || char.IsLower(cha))
                            oneLower = true;
                        else if (!oneNum || char.IsNumber(cha))
                            oneNum = true;
                    if (oneNum && oneUpper && oneLower)
                        password = value;
                    return;
                }
                password = "";

            }

            get
            {
                return password;
            }
        }

        public string PasswordSpecs
        {
            get { return "between 8 to 128 characters, at least one uppercase letter, one lowercase letter and one number"; }
        }
    }
}
