using Roster.Players;
using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace Roster.RosterLoading
{
    public class LocalRosterLoader : IRosterLoader
    {
        public List<Player> LoadRoster(string[] args)
        {
            string filePath = args[0];
            List<Player> initialPlayers = new List<Player>();
            try
            {
                using (TextReader reader = new StreamReader(new FileStream(filePath, FileMode.Open)))
                {
                    while (reader.Peek() != -1)
                    {
                        initialPlayers.Add(new Player() { Name = reader.ReadLine() });
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Output.Display.Show("Couldn't find the default roster");
            }

            return initialPlayers;
        }
    }
}
