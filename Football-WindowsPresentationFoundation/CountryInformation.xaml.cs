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
using System.Windows.Shapes;

namespace Football_WindowsPresentationFoundation
{
    public partial class CountryInformation : Window
    {
        private Result teamm;
        public CountryInformation(Result team)
        {
            InitializeComponent();
            this.teamm = team;
            lblDrzava.Content = teamm.Country;
            lblPobjedeRezultat.Content = teamm.Wins;
            lblIzgubljeneRezultat.Content = teamm.Losses;
            lblNeriješeneRezultat.Content = teamm.Draws;
            lblOdigraneUtakmiceRezultat.Content = teamm.GamesPlayed;
            lblBodoviRezultat.Content = teamm.Points;
            lblBrojZabijenihGolovaRezultat.Content = teamm.GoalsFor;
            lblBrojPrimljenihGolovaRezultat.Content = teamm.GoalsAgainst;
            lblRazlikaRezultat.Content = teamm.GoalsFor - teamm.GoalDifferential;
        }
        private void btnCountryInformation_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
