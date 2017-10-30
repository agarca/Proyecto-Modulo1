using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    public class Player
    {
        #region Members
        private string nickName;
        public string NickName
        {
            get { return nickName; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private Countries country;
        public Countries Country
        {
            get { return country; }
            set { country = value; }
        }
        #endregion
        
        public Player(string nickName, string email, Countries country)
        {
            this.nickName = nickName;
            this.email = email;
            this.country = country;
        }

        public Player(string data)
        {
            string[] splittedData = data.Split('-');
            this.nickName = splittedData[0];
            this.email = splittedData[1];
            this.country = (Countries)int.Parse(splittedData[2]);
        }

        public override bool Equals(object obj)
        {
            if (obj is Player)
            {
                Player aux = (Player)obj;
                return this.nickName == aux.nickName;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string s = nickName + " - " + email + " - " + country;
            return s;
        }
    }
}
