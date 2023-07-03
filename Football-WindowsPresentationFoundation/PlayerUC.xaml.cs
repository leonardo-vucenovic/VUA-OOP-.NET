using Data_Access_Layer.Models;
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

namespace Football_WindowsPresentationFoundation
{
    public partial class PlayerUC : UserControl
    {
        private Player Player;
        public PlayerUC(Player player)
        {
            InitializeComponent();
            this.Player = player;
            lblImeIPrezime.Content = Player.FullName;
            lblBrojDresa.Content = Player.ShirtNumber;
        }

        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int goals = 0;
            int yellowcard = 0;

            PlayerInformation playerInformation = new PlayerInformation(Player, goals, yellowcard);
            playerInformation.ShowDialog();
        }
    }
}
