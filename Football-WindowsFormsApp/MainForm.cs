using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Data_Access_Layer;
using Data_Access_Layer.Models;
using Data_Access_Layer.Repository;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Football_WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private const string HR = "Hrvatski-Croatian";
        private const string EN = "Engleski-English";

        private const string hr = "hr";
        private const string en = "en";
        private List<Team> teams;
        private string countryname = CheckSettings.LoadFavoriteCountry();
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            btnPrikazeIgraceZaOdabranuDrzavu.Visible = false;
            btnPrikaziStatistikuZaOdabranuDrzavu.Visible = false;
            bool gender = CheckSettings.LoadGender();
            bool apifile = CheckSettings.LoadAPIFILESettings();
            LoadData(gender, apifile);
        }
        private void LoadData(bool gender, bool apifile)
        {
            lblLoading.Text = "Loading..";
            if (apifile == true)
            {
                try
                {
                    LoadTeamsFILE(gender);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                try
                {
                    LoadTeamsAPI(gender);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        private async void LoadTeamsAPI(bool gender)
        {
            ApiRepository apiRepository = new ApiRepository();
            if (gender == true)
            {
                try
                {
                    teams = await apiRepository.GetTeams(true);
                    cbOmiljeniTim.DataSource = teams;
                    Thread.Sleep(1000);
                    lblLoading.Text = "";
                    pbLoading.Visible = false;
                    btnPrikazeIgraceZaOdabranuDrzavu.Visible = true;
                    btnPrikaziStatistikuZaOdabranuDrzavu.Visible = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                try
                {
                    teams = await apiRepository.GetTeams(false);
                    cbOmiljeniTim.DataSource = teams;
                    Thread.Sleep(1000);
                    lblLoading.Text = "";
                    pbLoading.Visible = false;
                    btnPrikazeIgraceZaOdabranuDrzavu.Visible = true;
                    btnPrikaziStatistikuZaOdabranuDrzavu.Visible = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public async Task LoadTeamsFILE(bool gender)
        {
            FileRepository filerepository = new FileRepository();
            if (gender == true)
            {
                try
                {
                    teams = await filerepository.GetTeams(true);
                    cbOmiljeniTim.DataSource = teams;
                    lblLoading.Text = "";
                    pbLoading.Visible = false;
                    btnPrikazeIgraceZaOdabranuDrzavu.Visible = true;
                    btnPrikaziStatistikuZaOdabranuDrzavu.Visible = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                try
                {
                    teams = await filerepository.GetTeams(false);
                    cbOmiljeniTim.DataSource = teams;
                    lblLoading.Text = "";
                    pbLoading.Visible = false;
                    btnPrikazeIgraceZaOdabranuDrzavu.Visible = true;
                    btnPrikaziStatistikuZaOdabranuDrzavu.Visible = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        private void btnPostavke_Click(object sender, EventArgs e)
        {
            try
            {
                CheckSettings.SaveFavoriteCountry(cbOmiljeniTim.Text);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            this.Hide();
            SettingsForm settingform = new SettingsForm();
            settingform.ShowDialog();
            this.Close();
        }
        private void btnPrikazeIgraceZaOdabranuDrzavu_Click(object sender, EventArgs e)
        {
            flpSviIgraci.Controls.Clear();
            string name = null;
            bool gender = CheckSettings.LoadGender();
            try
            {
                CheckSettings.SaveFavoriteCountry(cbOmiljeniTim.Text);
                name = CheckSettings.LoadFavoriteCountry();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            bool apifile = CheckSettings.LoadAPIFILESettings();
            List<Player> players = new List<Player>();
            FileRepository fileRepository = new FileRepository();
            ApiRepository apiRepository = new ApiRepository();
            if (apifile == true)
            {
                List<Match> matches = fileRepository.GetMatches(gender).Result;
                foreach (Match match in matches)
                {
                    if (match.HomeTeamCountry == name)
                    {
                        players.AddRange(match.HomeTeamStatistics.StartingEleven);
                        players.AddRange(match.HomeTeamStatistics.Substitutes);
                        break;
                    }
                    if (match.AwayTeamCountry == name)
                    {
                        players.AddRange(match.AwayTeamStatistics.StartingEleven);
                        players.AddRange(match.AwayTeamStatistics.Substitutes);
                        break;
                    }
                }
                foreach (Player player in players)
                {
                    flpSviIgraci.Controls.Add(new PlayerUC(player));
                }
            }
            else
            {
                List<Match> matches = apiRepository.GetMatches(gender).Result;
                foreach (Match match in matches)
                {
                    if (match.HomeTeamCountry == name)
                    {
                        players.AddRange(match.HomeTeamStatistics.StartingEleven);
                        players.AddRange(match.HomeTeamStatistics.Substitutes);
                        break;
                    }
                    if (match.AwayTeamCountry == name)
                    {
                        players.AddRange(match.AwayTeamStatistics.StartingEleven);
                        players.AddRange(match.AwayTeamStatistics.Substitutes);
                        break;
                    }
                }
                foreach (Player player in players)
                {
                    flpSviIgraci.Controls.Add(new PlayerUC(player));
                }
            }
        }
        private void btnPrikaziStatistikuZaOdabranuDrzavu_Click(object sender, EventArgs e)
        {
            try
            {
                CheckSettings.SaveFavoriteCountry(cbOmiljeniTim.Text);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            this.Hide();
            RangLists rangList = new RangLists();
            rangList.ShowDialog();
            this.Hide();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckSettings.SaveFavoriteCountry(cbOmiljeniTim.Text);
            DialogResult result = MessageBox.Show("Jeste li sigurni ?", "Upozorenje!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void flpOmiljeniIgraci_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void flpSviIgraci_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void flpOmiljeniIgraci_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string msg = "You can only drag and drop 3 players!";
                List<PlayerUC> favorites = GetSelectedPlayers(flpSviIgraci);
                if (flpOmiljeniIgraci.Controls.Count + favorites.Count < 4)
                {
                    MovingSelectedPlayersFromAllPlayersToFavoritePlayers(favorites, flpSviIgraci, flpOmiljeniIgraci);
                }
                else
                {
                    MessageBox.Show(msg, "Warning!");
                    foreach (PlayerUC player in favorites)
                    {
                        player.UnselecPlayer();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void flpSviIgraci_DragDrop(object sender, DragEventArgs e)
        {
            List<PlayerUC> favoritePlayers = GetSelectedPlayers(flpOmiljeniIgraci);
            MovingSelectedPlayersFromFavoritPanelToAllPlayers(favoritePlayers, flpOmiljeniIgraci, flpSviIgraci);
        }
        private List<PlayerUC> GetSelectedPlayers(FlowLayoutPanel flpAllPlayers)
        {
            List<PlayerUC> favoritePlayersForMove = new List<PlayerUC>();
            foreach (PlayerUC player in flpAllPlayers.Controls)
            {
                if (player.SelectedPlayer)
                {
                    favoritePlayersForMove.Add(player);
                }
            }
            return favoritePlayersForMove;
        }

        private void MovingSelectedPlayersFromFavoritPanelToAllPlayers(List<PlayerUC> favoritePlayers, FlowLayoutPanel flpFavoritePlayers, FlowLayoutPanel flpAllPlayers)
        {
            foreach (PlayerUC player in favoritePlayers)
            {
                if (player.SelectedPlayer)
                {
                    player.UnselecPlayer();
                }
                flpAllPlayers.Controls.Add(player);
                flpFavoritePlayers.Controls.Remove(player);
                player.RemoveStar();
            }
        }
        private void MovingSelectedPlayersFromAllPlayersToFavoritePlayers(List<PlayerUC> favorites, FlowLayoutPanel flpAllPlayers, FlowLayoutPanel flpFavorites)
        {
            foreach (PlayerUC player in favorites)
            {
                if (player.SelectedPlayer)
                {
                    player.UnselecPlayer();
                }
                flpAllPlayers.Controls.Remove(player);
                flpFavorites.Controls.Add(player);
                player.CreateStar();
            }
        }
    }
}
