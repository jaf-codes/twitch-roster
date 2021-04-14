using Roster.Players;
using Roster.RosterLoading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Roster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadDefaultRoster("C:\\Users\\jafan\\source\\repos\\TwitchRoster\\Roster\\defaultPlayers.txt");
        }

        private void LoadDefaultRoster(string rosterFilePath)
        {
            IRosterLoader rosterLoader = new LocalRosterLoader();
            List<Player> playerList = rosterLoader.LoadRoster(new string[1] { rosterFilePath });
            foreach (Player player in playerList)
            {
                theGoodStuff.Items.Add(PlayerLabel.Create(player));
            }
        }

        private void CopyToClipboard()
        {
            Clipboard.SetText(SelectedPlayer.Text);
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(theGoodStuff.SelectedItem is PlayerLabel selectedPlayer))
                return;
            SelectedPlayer.Text = selectedPlayer.Text;
            if (CopiesOnClick.IsChecked == true)
                CopyToClipboard();
        }

        private void Manual_Add_Button_Click(object sender, RoutedEventArgs e)
        {
            theGoodStuff.Items.Add(PlayerLabel.Create(new Player(){ Name = PlayerToAdd.Text}));
        }
        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!NoForRealIAmSure.IsChecked == true)
                return;
            theGoodStuff.Items.Clear();
            SelectedPlayer.Text = string.Empty;
        }

        private void Copy_Button_Click(object sender, RoutedEventArgs e)
        {
            CopyToClipboard();
        }

        private void TO_THE_PIT_Button_Click(object sender, RoutedEventArgs e)
        {
            var copy = theGoodStuff.SelectedItem;
            theGoodStuff.Items.Remove(theGoodStuff.SelectedItem);
            theGoodStuff.Items.Add(copy);
        }

        private void Remove_Player_Button_Click(object sender, RoutedEventArgs e)
        {
            theGoodStuff.Items.Remove(theGoodStuff.SelectedItem);
        }
    }
}
