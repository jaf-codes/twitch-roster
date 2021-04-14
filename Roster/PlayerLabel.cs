using Roster.Players;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Roster
{
    public class PlayerLabel: TextBlock
    {
        public static PlayerLabel Create(Player player)
        {
            return new PlayerLabel()
            {
                Text = player.Name,
            };
        }
    }
}
