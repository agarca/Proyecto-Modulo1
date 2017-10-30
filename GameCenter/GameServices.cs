using System;
using System.Collections.Generic;
using System.IO;

namespace GameCenter
{
    public static class GameServices
    {
        #region Members
        private static List<Player> players;
        public static List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }

        private static List<Game> games;
        public static List<Game> Games
        {
            get { return games; }
            set { games = value; }
        }
        #endregion

        //Ruta con el archivo txt donde se exportan los datos
        private const string PATH = "../../Resources/data.txt";

        public static void Export()
        {
            //Convertir Player en string
            string playerData = ConvertPlayersToString();
            //Convertir Game en string
            string gameData = ConvertGameToString();
            //Convertir Ranking y Score en string
            // Escribir en el fichero los datos anteriores separados por el patron '*+*+*+*'
            try
            {
                StreamWriter file = File.CreateText(PATH);
                string completeData = playerData + "*+*+*+*\n" + gameData;
                file.Write(completeData);
                file.Close();
                Console.WriteLine("Datos exportados correctamente");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al exportar los datos. " + e);
            }
        }

        private static string ConvertPlayersToString()
        {
            string data = "";

            foreach (Player player in Players)
            {
                string playerData = "";
                playerData = player.NickName + "-" + player.Email + "-" + player.Country + "\n";
                data += playerData;
            }
            return data;
        }

        private static string ConvertGameToString()
        {
            string data = "";
            foreach (Game game in Games)
            {
                string gameData = "";
                gameData = game.Name + "-" + game.Genre + "-" + game.ReleaseDate + "-" + game.Platforms + "\n";
                data += gameData;
            }
            return data;
        }

        //Tercera parte
        //Juego más antiguo de la empresa
        public static Game OldestGame()
        {
            Game oldestGame = null;
            int releaseDate = int.MaxValue;
            foreach (Game game in Games)
            {
                int rD = game.ReleaseDate;
                if (releaseDate > rD)
                {
                    oldestGame = game;
                    releaseDate = rD;
                }
            }
            return oldestGame;
        }

        //Juegos de un determinado genero
        public static int GameByGenre(Genres genre)
        {
            int count = 0;
            foreach (Game game in games)
            {
                if (game.Genre == genre)
                {
                    count++;
                }
            }
            return count;
        }

        //Cuarta parte - Intérprete de consola
        public static void InterpreteConsola()
        {
            while (true)
            {
                Console.WriteLine("Introduzca un comando: ");
                string frase = Console.ReadLine();

                //Pasar a minuscula la frase
                //frase = frase.ToLower();

                //Trocear para averiguar el comando y el valor
                string[] splitted = frase.Split(' ');
                string comando = splitted[0];
                string valor = "";
                if (splitted.Length > 1)
                {
                    valor = splitted[1];
                }

                //Averiguar con un switch el comando introducido
                switch (comando)
                {
                    case "import":
                        Console.WriteLine("Opción no disponible en esta versión");
                        //GameServices.Import();
                        break;
                    case "export":
                        GameServices.Export();
                        break;
                    case "oldest":
                        OldestGame();
                        break;
                    case "scoreCount":
                        Console.WriteLine("Opción no disponible en esta versión");
                        break;
                    case "gamesCountByGenre":
                        GameByGenre((Genres)Enum.Parse(typeof(Genres), valor));
                        break;
                    case "gamesByPlayer":
                        Console.WriteLine("Opción no disponible en esta versión");
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
