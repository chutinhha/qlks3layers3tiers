using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DTO
{
    public class UserDTO
    {
        int _IdUser;

        public int IdUser
        {
            get { return _IdUser; }
            set { _IdUser = value; }
        }
        string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        string _PassWord;

        public string PassWord
        {
            get { return _PassWord; }
            set { _PassWord = value; }
        }
        string _IdKUser;

        public string IdKUser
        {
            get { return _IdKUser; }
            set { _IdKUser = value; }
        }
        string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
    }
}
