using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    public class Score
    {
        #region Members
        private string nickName;
        public string NickName
        {
            get { return nickName; }
        }

        private int points;
        public int Points
        {
            get { return points; }
            set
            {
                if (points >= 0)
                {
                    points = value;
                }
                else
                {
                    Console.WriteLine("Los puntos no pueden ser negativos");
                }
            }
        }
        #endregion

        public Score(string nickName, int points)
        {
            this.nickName = nickName;
            if (points >= 0)
            {
                this.points = points;
            }
            else
            {
                Console.WriteLine("Los puntos no pueden ser negativos");
            }

        }

        public override string ToString()
        {
            string s = nickName + " - " + points;
            return s;
        }
    }
}
