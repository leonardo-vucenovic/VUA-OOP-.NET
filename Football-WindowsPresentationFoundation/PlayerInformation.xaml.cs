using Data_Access_Layer;
using Data_Access_Layer.Models;
using Data_Access_Layer.Repository;
using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace Football_WindowsPresentationFoundation
{
    public partial class PlayerInformation : Window
    {
        public PlayerInformation(Player player,int goals,int yellowcards)
        {
            InitializeComponent();
            SetInformation(player, goals, yellowcards);
        }
        private void SetInformation(Player player, int goals, int yellowcards)
        {
            lblImeiPrezime.Content = player.FullName;
            lblBrojDresa.Content = player.ShirtNumber;
            lblKapetanRezultat.Content = player.Captain ? "Da" : "Ne";
            lblPozicijaRezultat.Content = player.Position;
            lblGoloviRezultat.Content = goals;
            lblŽutiKartoniRezultat.Content = yellowcards;
        }
        private void btnPlayerInformation_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
