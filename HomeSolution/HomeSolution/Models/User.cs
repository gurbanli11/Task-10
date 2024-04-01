using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSolution.Models
{
    internal class User
    {
        string _name = "AAA";
        string _surname = "BBB";
        string _userName;
        string _password = "12345678";



        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (CheckLetter(value.Trim()) && value.Length > 2 && value.Length < 25)
                {
                    _name = Capitalize(value);
                }
                else
                {
                    Console.WriteLine("Ad yanlishdir");
                }
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (CheckLetter(value.Trim()) && value.Length > 2 && value.Length < 25)
                {
                    _name = Capitalize(value);
                }
                else
                {
                    Console.WriteLine("Soyad yanlishdir");
                }
            }
        }

        public string UserName
        {
            get
            {
                return _userName;
            }
        }

        public string Password
        {
            set
            {
                if (value.Length >= 8 && IsLower(value) && IsUpper(value) && IsDigit(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Shifreni duzeldin");
                }
            }
        }
        public User(string name, string surname, string password)
        {
            Name = name.Substring(3);
            Surname = surname.Substring(3);
            _userName = String.Concat(Name.Substring(0, 3), '.', Surname.Substring(0, 3));
            Password = _password;
        }
        private string Capitalize(string name)
        {
            name = name.Trim();
            name = String.Concat(name.Substring(0, 1).ToUpper(), name.Substring(1).ToLower());
            return name;
        }
        private bool CheckLetter(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!Char.IsLetter(name[i]))
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsLower(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsLower(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsUpper(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsDigit(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public void ChangePass(string oldPass, string newPass)
        {
            if (oldPass == _password)
            {
                if (IsLower(newPass) && IsUpper(newPass) && IsDigit(newPass))
                {
                    Password = newPass;
                }
            }
        }
    }
}
