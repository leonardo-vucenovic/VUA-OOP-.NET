using Data_Access_Layer;
using Data_Access_Layer.Models;
using Data_Access_Layer.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
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
    public partial class Football : Window
    {
        private List<Match> matches;
        public Football()
        {
            InitializeComponent();
            string resolution = "Full screen";
            try
            {
                resolution = CheckSettings.LoadResolutionWPF();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SetResolution(resolution);
        }
        private void btnPostavke_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            this.Close();
            settings.ShowDialog();
        }
        private void SelectionChangedDomaciTim(object sender, SelectionChangedEventArgs e)
        {
            DomaciGolman.Children.Clear();
            DomaciObrana.Children.Clear();
            DomaciSredina.Children.Clear();
            DomaciNapad.Children.Clear();
            GostujuciGolman.Children.Clear();
            GostujuciObrana.Children.Clear();
            GostujuciSredina.Children.Clear();
            GostujuciNapad.Children.Clear();
            LoadAwayTeam();
            cbGostujuciTim.SelectedIndex = 0;
        }
        private void SelectionChangedGostujuciTim(object sender, SelectionChangedEventArgs e)
        {
            DomaciGolman.Children.Clear();
            DomaciObrana.Children.Clear();
            DomaciSredina.Children.Clear();
            DomaciNapad.Children.Clear();
            GostujuciGolman.Children.Clear();
            GostujuciObrana.Children.Clear();
            GostujuciSredina.Children.Clear();
            GostujuciNapad.Children.Clear();
            lblRezultatDomaciTim.Content = "-";
            lblRezultatGostujuciTim.Content = "-";
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadAllHomeTeam();
            cbDomaciTim.SelectedIndex = 0;
            LoadAwayTeam();
            cbGostujuciTim.SelectedIndex = 0;
        }
        private void SetResolution(string resolution)
        {
            if (resolution == null)
            {
                MessageBox.Show("");
            }
            else if (resolution == "Small")
            {
                this.Width = 1000;
                this.Height = 800;
            }
            else if (resolution == "Big")
            {
                this.Width = 1200;
                this.Height =1000;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }
        private void btnPokaziRezultat_Click(object sender, RoutedEventArgs e)
        {
            ShowResult();
            ShowAllPlayersOnFiels();
        }
        private void ShowAllPlayersOnFiels()
        {
            FileRepository repository = new FileRepository();
            ApiRepository apiRepository = new ApiRepository();
            List<Match> matchs = new List<Match>();
            string domaci = cbDomaciTim.SelectedItem.ToString();
            string gostujuci = cbGostujuciTim.SelectedItem.ToString();
            if (CheckSettings.LoadAPIFILESettingsWPF() == true)
            {
                if (CheckSettings.LoadGenderWPF() == true)
                {
                    try
                    {
                        matchs = repository.GetMatches(true).Result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        matchs = repository.GetMatches(false).Result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                if (CheckSettings.LoadGenderWPF() == true)
                {
                    try
                    {
                        matchs = apiRepository.GetMatches(true).Result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        matchs = apiRepository.GetMatches(false).Result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            foreach (var match in matchs)
            {
                if (match.HomeTeamCountry == domaci && match.AwayTeamCountry == gostujuci)
                {
                    FillFielHomeTeam(match.HomeTeamStatistics);
                    FillFieldAwayTeam(match.AwayTeamStatistics);
                }
                else if (match.AwayTeamCountry == domaci && match.HomeTeamCountry == gostujuci)
                {
                    FillFielHomeTeam(match.AwayTeamStatistics);
                    FillFieldAwayTeam(match.HomeTeamStatistics);
                }
            }
        }
        private void FillFielHomeTeam(TeamStatistics hometeamstatistic)
        {
            DomaciGolman.Children.Clear();
            DomaciObrana.Children.Clear();
            DomaciSredina.Children.Clear();
            DomaciNapad.Children.Clear();
            foreach (var player in hometeamstatistic.StartingEleven)
            {
                PlayerUC playerUC = new PlayerUC(player)
                {
                    Margin = new Thickness(10, 5, 10, 5)
                };
                if (player.Position == "Goalie")
                {
                    DomaciGolman.Children.Add(playerUC);
                }
                else if(player.Position == "Defender")
                {
                    DomaciObrana.Children.Add(playerUC);
                }
                else if (player.Position == "Midfield")
                {
                    DomaciSredina.Children.Add(playerUC);
                }
                else if(player.Position == "Forward")
                {
                    DomaciNapad.Children.Add(playerUC);
                }
            }
        }
        private void FillFieldAwayTeam(TeamStatistics awayteamstatistic)
        {
            GostujuciGolman.Children.Clear();
            GostujuciObrana.Children.Clear();
            GostujuciSredina.Children.Clear();
            GostujuciNapad.Children.Clear();
            foreach (var player in awayteamstatistic.StartingEleven)
            {
                PlayerUC playerUC = new PlayerUC(player)
                {
                    Margin = new Thickness(10, 5, 10, 5)
                };
                if (player.Position == "Goalie")
                {
                    GostujuciGolman.Children.Add(playerUC);
                }
                else if (player.Position == "Defender")
                {
                    GostujuciObrana.Children.Add(playerUC);
                }
                else if (player.Position == "Midfield")
                {
                    GostujuciSredina.Children.Add(playerUC);
                }
                else if (player.Position == "Forward")
                {
                    GostujuciNapad.Children.Add(playerUC);
                }
            }
        }
        private void ShowResult()
        {
            FileRepository fileRepository = new FileRepository();
            ApiRepository apiRepository = new ApiRepository();
            bool gender = CheckSettings.LoadGenderWPF();
            bool apifile = CheckSettings.LoadAPIFILESettingsWPF();
            string domaci = cbDomaciTim.Text;
            string gostujuci = cbGostujuciTim.Text;

            if (apifile == true)
            {
                if (gender == true)
                {
                    matches = fileRepository.GetMatches(true).Result;
                }
                else
                {
                    matches = fileRepository.GetMatches(false).Result;
                }
            }
            else
            {
                if (gender == true)
                {
                    matches = apiRepository.GetMatches(true).Result;
                }
                else
                {
                    matches = apiRepository.GetMatches(false).Result;
                }
            }
            foreach (var match in matches)
            {
                if (match.HomeTeamCountry == cbDomaciTim.Text || match.AwayTeamCountry == cbDomaciTim.Text)
                {
                    if (match.HomeTeamCountry == cbGostujuciTim.Text || match.AwayTeamCountry == cbGostujuciTim.Text)
                    {
                        ShowExactGameResult(match);
                    }
                }
            }
        }
        private void ShowExactGameResult(Match match)
        {
            if (match.HomeTeamCountry == cbDomaciTim.Text)
            {
                lblRezultatDomaciTim.Content = match.HomeTeam.Goals;
                lblRezultatGostujuciTim.Content = match.AwayTeam.Goals;
            }
            else
            {
                lblRezultatDomaciTim.Content = match.AwayTeam.Goals;
                lblRezultatGostujuciTim.Content = match.HomeTeam.Goals;
            }
        }
        private void LoadAllHomeTeam()
        {
            ApiRepository apiRepository = new ApiRepository();
            FileRepository fileRepository = new FileRepository();
            List<Team> teams = new List<Team>();
            if (CheckSettings.LoadAPIFILESettingsWPF() == true)
            {
                if (CheckSettings.LoadGenderWPF())
                {
                    try
                    {
                        teams = fileRepository.GetTeams(true).Result;
                        foreach (var team in teams)
                        {
                            cbDomaciTim.Items.Add(team);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        teams = fileRepository.GetTeams(false).Result;
                        foreach (var team in teams)
                        {
                            cbDomaciTim.Items.Add(team);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                if (CheckSettings.LoadGenderWPF())
                {
                    try
                    {
                        teams = apiRepository.GetTeams(true).Result;
                        foreach (var team in teams)
                        {
                            cbDomaciTim.Items.Add(team);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        teams = apiRepository.GetTeams(false).Result;
                        foreach (var team in teams)
                        {
                            cbDomaciTim.Items.Add(team);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void LoadAwayTeam()
        {
            string drzava = cbDomaciTim.SelectedItem.ToString();
            List<string> finalteam = new List<string>();
            List<Match> filtermatch = new List<Match>();
            cbGostujuciTim.Items.Clear();
            bool gender = CheckSettings.LoadGenderWPF();
            FileRepository fileRepository = new FileRepository();
            ApiRepository apiRepository = new ApiRepository();
            if (CheckSettings.LoadAPIFILESettingsWPF() == true) 
            {
                if (gender == true)
                {
                    try
                    {
                        List<Match> allmatchs = fileRepository.GetMatches(true).Result;
                        foreach (Match match in allmatchs)
                        {
                            if (match.HomeTeamCountry == drzava || match.AwayTeamCountry == drzava)
                            {
                                filtermatch.Add(match);
                            }
                        }
                        foreach (var m in filtermatch)
                        {
                            if (m.HomeTeamCountry == drzava)
                            {
                                finalteam.Add(m.AwayTeamCountry.ToString());
                            }
                            if (m.AwayTeamCountry == drzava)
                            {
                                finalteam.Add(m.HomeTeamCountry.ToString());
                            }
                        }
                        foreach (var item in finalteam)
                        {
                            cbGostujuciTim.Items.Add(item.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        List<Match> allmatchs = fileRepository.GetMatches(false).Result;
                        foreach (Match match in allmatchs)
                        {
                            if (match.HomeTeamCountry == drzava || match.AwayTeamCountry == drzava)
                            {
                                filtermatch.Add(match);
                            }
                        }
                        foreach (var m in filtermatch)
                        {
                            if (m.HomeTeamCountry == drzava)
                            {
                                finalteam.Add(m.AwayTeamCountry.ToString());
                            }
                            if (m.AwayTeamCountry == drzava)
                            {
                                finalteam.Add(m.HomeTeamCountry.ToString());
                            }
                        }
                        foreach (var item in finalteam)
                        {
                            cbGostujuciTim.Items.Add(item.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                if (gender == true)
                {
                    try
                    {
                        List<Match> allmatchs = apiRepository.GetMatches(true).Result;
                        foreach (Match match in allmatchs)
                        {
                            if (match.HomeTeamCountry == drzava || match.AwayTeamCountry == drzava)
                            {
                                filtermatch.Add(match);
                            }
                        }
                        foreach (var m in filtermatch)
                        {
                            if (m.HomeTeamCountry == drzava)
                            {
                                finalteam.Add(m.AwayTeamCountry.ToString());
                            }
                            if (m.AwayTeamCountry == drzava)
                            {
                                finalteam.Add(m.HomeTeamCountry.ToString());
                            }
                        }
                        foreach (var item in finalteam)
                        {
                            cbGostujuciTim.Items.Add(item.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        List<Match> allmatchs = fileRepository.GetMatches(false).Result;
                        foreach (Match match in allmatchs)
                        {
                            if (match.HomeTeamCountry == drzava || match.AwayTeamCountry == drzava)
                            {
                                filtermatch.Add(match);
                            }
                        }
                        foreach (var m in filtermatch)
                        {
                            if (m.HomeTeamCountry == drzava)
                            {
                                finalteam.Add(m.AwayTeamCountry.ToString());
                            }
                            if (m.AwayTeamCountry == drzava)
                            {
                                finalteam.Add(m.HomeTeamCountry.ToString());
                            }
                        }
                        foreach (var item in finalteam)
                        {
                            cbGostujuciTim.Items.Add(item.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void btnDomaciTimInfo_Click(object sender, RoutedEventArgs e)
        {
            FileRepository fileRepository = new FileRepository();
            ApiRepository apiRepository = new ApiRepository();
            List<Result> teams = new List<Result>();
            bool gender = CheckSettings.LoadGenderWPF();
            bool apifile = CheckSettings.LoadAPIFILESettingsWPF();
            if (apifile == true)
            {
                if (gender == true)
                {
                    teams.Clear();
                    teams = fileRepository.GetResults(true).Result;
                    foreach (var team in teams)
                    {
                        if (team.Country == cbDomaciTim.Text)
                        {
                            CountryInformation countryInformation = new CountryInformation(team);
                            countryInformation.ShowDialog();
                            break;
                        }
                    }
                }
                else
                {
                    teams.Clear();
                    teams = fileRepository.GetResults(false).Result;
                    foreach (var team in teams)
                    {
                        if (team.Country == cbDomaciTim.Text)
                        {
                            CountryInformation countryInformation = new CountryInformation(team);
                            countryInformation.ShowDialog();
                            break;
                        }
                    }
                }
            }
            if (apifile == false)
            {
                if (gender == true)
                {
                    teams.Clear();
                    teams = apiRepository.GetResults(true).Result;
                    foreach (var team in teams)
                    {
                        if (team.Country == cbDomaciTim.Text)
                        {
                            CountryInformation countryInformation = new CountryInformation(team);
                            countryInformation.ShowDialog();
                            break;
                        }
                    }
                }
                else
                {
                    teams.Clear();
                    teams = apiRepository.GetResults(false).Result;
                    foreach (var team in teams)
                    {
                        if (team.Country == cbDomaciTim.Text)
                        {
                            CountryInformation countryInformation = new CountryInformation(team);
                            countryInformation.ShowDialog();
                            break;
                        }
                    }
                }
            }
        }
        private void btnGostujuciTimInfo_Click(object sender, RoutedEventArgs e)
        {
            FileRepository fileRepository = new FileRepository();
            ApiRepository apiRepository = new ApiRepository();
            List<Result> teams = new List<Result>();
            bool gender = CheckSettings.LoadGenderWPF();
            bool apifile = CheckSettings.LoadAPIFILESettingsWPF();
            if (apifile == true)
            {
                if (gender == true)
                {
                    teams.Clear();
                    teams = fileRepository.GetResults(true).Result;
                    foreach (var team in teams)
                    {
                        if (team.Country == cbGostujuciTim.Text)
                        {
                            CountryInformation countryInformation = new CountryInformation(team);
                            countryInformation.ShowDialog();
                            break;
                        }
                    }
                }
                else
                {
                    teams.Clear();
                    teams = fileRepository.GetResults(false).Result;
                    foreach (var team in teams)
                    {
                        if (team.Country == cbGostujuciTim.Text)
                        {
                            CountryInformation countryInformation = new CountryInformation(team);
                            countryInformation.ShowDialog();
                            break;
                        }
                    }
                }
            }
            if (apifile == false)
            {
                if (gender == true)
                {
                    teams.Clear();
                    teams = apiRepository.GetResults(true).Result;
                    foreach (var team in teams)
                    {
                        if (team.Country == cbGostujuciTim.Text)
                        {
                            CountryInformation countryInformation = new CountryInformation(team);
                            countryInformation.ShowDialog();
                            break;
                        }
                    }
                }
                else
                {
                    teams.Clear();
                    teams = apiRepository.GetResults(false).Result;
                    foreach (var team in teams)
                    {
                        if (team.Country == cbGostujuciTim.Text)
                        {
                            CountryInformation countryInformation = new CountryInformation(team);
                            countryInformation.ShowDialog();
                            break;
                        }
                    }
                }
            }
        }

        
    }
}