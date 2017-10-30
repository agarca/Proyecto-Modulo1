using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    public class Game
    {
        #region Members
        private string name;
        public string Name
        {
            get { return name; }
        }

        private Genres genre;
        public Genres Genre
        {
            get { return genre; }
        }

        private List<Platforms> platforms;
        public List<Platforms> Platforms
        {
            get { return platforms; }
        }

        private int releaseDate;
        public int ReleaseDate
        {
            get { return releaseDate; }
        }

        private Dictionary<Platforms, Ranking> rankings;
        public Dictionary<Platforms, Ranking> Rankings
        {
            get { return rankings; }
        }

        #endregion
       
        public Game(string name, Genres genre, List<Platforms> platforms, int releaseDate, Dictionary<Platforms, Ranking> rankings)
        {
            this.name = name;
            this.genre = genre;
            this.platforms = platforms;
            if (releaseDate >= 1980 && releaseDate <= 2018)
            {
                this.releaseDate = releaseDate;
            }
            else
            {
                Console.WriteLine("La fecha de salida tiene que estar comprendida entre los años 1980 y 2018");
            }
            this.rankings = rankings;
        }              

        public override bool Equals(object obj)
        {
            if (obj is Game)
            {
                Game aux = (Game)obj;
                return this.name == aux.name;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string s = "--- " + name + " (" + releaseDate + ") - ";
            foreach (Platforms platform in platforms)
            {
                s += platform + ", ";
            }
            s += " - " + genre + " ---\n         Rankings:";

            foreach (Ranking ranking in rankings.Values)
            {
                s += "\n" + "          - "+ranking.Name + " (" + ranking.Scores.Count + ")";

            }
            return s;
        }
    }
}