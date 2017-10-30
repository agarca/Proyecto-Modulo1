using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            Test.DoTest();
            GameServices.InterpreteConsola();
            Console.ReadLine();

            //Player p1 = new Player("player1", "player1@player", Countries.Australia);
            //Player p2 = new Player("player2", "player2@player2", Countries.Spain);
            //Console.WriteLine(p1);
            //Console.WriteLine("p1 vs p2");
            //Console.WriteLine(p1.Equals(p2));
        }
    }
}
