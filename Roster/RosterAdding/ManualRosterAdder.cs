using Roster.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roster.RosterAdding
{
    public class ManualRosterAdder : IRosterAdder
    {
        public Player AddRoster(string[] args)
        {
            string playerName = args[0];
            return new Player() { Name = playerName };
        }
    }
}
