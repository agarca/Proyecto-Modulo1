using System;
using System.Collections.Generic;
using GameCenter;

public class Test
{
    public static void DoTest()
    {
        //Tests Player
        Player player1 = new Player("killer19", "killer@player1", Countries.Canada);
        Player player2 = new Player("r3m09", "r3m09@player2", Countries.Canada);
        Player player3 = new Player("Exilium", "Exilium@player3", Countries.Italy);
        Player player4 = new Player("sefir666", "sefir666@player4", Countries.Italy);
        Console.WriteLine(player2);

        //Tests Score & Ranking
        Score s1 = new Score("r3m09", 5000);
        Score s2 = new Score("killer19", 12000);
        Score s3 = new Score("sefir666", 30000);
        Score s4 = new Score("Exilium", 2000);

        List<Score> puntos1 = new List<Score>() { s1, s2 };
        List<Score> puntos2 = new List<Score>() { s3, s4 };
        //foreach (Score punto in puntos)
        //{
        //    Console.WriteLine(punto);
        //}
        Ranking r1 = new Ranking("Assists", puntos1);
        Ranking r2 = new Ranking("Kills", puntos2);
        Console.WriteLine(r1);
        Console.WriteLine(r2);

        //Tests Game
        List<Platforms> plat1 = new List<Platforms>();
        plat1.Add(Platforms.PS4);

        Dictionary<Platforms, Ranking> dic1 = new Dictionary<Platforms, Ranking>();
        dic1.Add(Platforms.PS4, r1);

        Dictionary<Platforms, Ranking> dic2 = new Dictionary<Platforms, Ranking>();
        dic2.Add(Platforms.PS4, r2);

        Game g1 = new Game("Crash Bandicoot", Genres.Adventure, plat1, 2017, dic1);
        Game g2 = new Game("Tomb Raider", Genres.Adventure, plat1, 2016, dic2);
        Console.WriteLine(g1);
        Console.WriteLine(g2);

        GameServices.Players = new List<Player>() {
            player1, player2, player3, player4
        };

        GameServices.Games = new List<Game>() {
            g1, g2
        };

        GameServices.Export();
        //GameServices.Import();
    }
}