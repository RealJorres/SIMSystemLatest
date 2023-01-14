using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMSystem.Model
{
    public class User
    {
        private string id;
        private string username;
        private string password;
        private string dateJoined;
        private string firstname;
        private string lastname;
        byte[]? profileImage;
        private string email;
        private string address;
        private string type;
        private bool isOnline;
        private bool isNotifEnabled;
        private bool isActive;
        private byte[] signature;

        public User()
        {

        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string DateJoined
        {
            get
            {
                return dateJoined;
            }

            set
            {
                dateJoined = value;
            }
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public bool IsOnline
        {
            get
            {
                return isOnline;
            }

            set
            {
                isOnline = value;
            }
        }

        public bool IsNotifEnabled
        {
            get
            {
                return isNotifEnabled;
            }

            set
            {
                isNotifEnabled = value;
            }
        }

        public byte[] Signature
        {
            get
            {
                return signature;
            }

            set
            {
                signature = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return isActive;
            }

            set
            {
                isActive = value;
            }
        }

        public byte[]? ProfileImage { get => profileImage; set => profileImage = value; }
    }
}
