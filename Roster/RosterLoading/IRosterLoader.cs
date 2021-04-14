using System;
using System.Collections.Generic;
using System.Text;

using Roster.Players;

namespace Roster.RosterLoading
{
    public interface IRosterLoader
    {
        public List<Player> LoadRoster(string[] args);
    }
}
