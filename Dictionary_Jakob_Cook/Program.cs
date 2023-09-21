using System;
using System.Collections.Generic;
using System.Collections;

namespace Dictionary_Jakob_Cook
{ 
    class Program
    {
        static void Main(string[] args) 
        {
            //The Code shows all of the top games from 1-10 
            Dictionary<int, string> topGames = new Dictionary<int, string>();
            topGames.Add(1, "Mortal Kombat 1");
            topGames.Add(2, "PayDay 3");
            topGames.Add(3, "Doom Eternal");
            topGames.Add(4, "Super Smash Brothers Ultimate");
            topGames.Add(5, "Sonic Frontiers");
            topGames.Add(6, "Tom Clancys Rainbow Six Siege");
            topGames.Add(7, "Baldurs Gate 3");
            topGames.Add(8, "Fortnite");
            topGames.Add(9, "My Talking Tom");
            topGames.Add(10, "Monster Hunter");
            //The Code that shows off the key/choice chosen
            foreach(KeyValuePair<int, string> kvp in topGames)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            //The code shows the game ou have selected when chosen
            if (topGames.ContainsKey(1)) 
            {
                Console.WriteLine($"My favorite game is: {topGames[1]}!");
            }

            string result = "";
            //all if else statements.
            topGames.TryGetValue(11, out result);

            if(result != "") 
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("There is no game in the eleventh position.");
            }

            if (topGames.ContainsKey(5)) 
            {
                topGames[5] = "Sonic Frontiers";            
            }

            Console.WriteLine(topGames[5]);

            Hashtable hashtable = new Hashtable(topGames);

            string favGame = (string)hashtable[1];

            Console.WriteLine($"Favorite Game: {favGame}");
            //this part is using state capitals to show the values
            Hashtable capitals = new Hashtable() {
                { "Oklahoma", "Oklahoma City" },
                { "New York", "Albany" },
                { "Texas", "Austin" },
                { "Ohio", "Columbus" }
            };

            foreach (DictionaryEntry kvp in capitals) 
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            capitals.Clear();

        }

    }
}