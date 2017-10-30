using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    public class Ranking
    {
        #region Members
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Score> scores;
        public List<Score> Scores
        {
            get { return scores; }
        }
        #endregion

        public Ranking(string name, List<Score> scores)
        {
            this.name = name;
            this.scores = scores;
        }

        public override string ToString()
        {
            int cont = 1;
            //scores.Sort();
            string s = "Ranking: " + name;
            foreach (Score score in scores)
            {
                s += "\n" + cont + "." + score.NickName + " - " + score;
                cont++;
            }
            return s;
        }
    }
}
