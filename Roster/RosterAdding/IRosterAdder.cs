using Roster.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roster.RosterAdding
{
    public interface IRosterAdder
    {
        public Player AddRoster(string[] args);
    }
}
