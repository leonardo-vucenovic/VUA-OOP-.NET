using Data_Access_Layer;
using Data_Access_Layer.Models;
using Data_Access_Layer.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_WindowsFormsApp
{
    public partial class RangLists : Form
    {
        private List<PLayerGoalUC> pLayerGoals;
        private List<PlayerYellowCardUC> playerYellows;
        private List<MatchUC> matchesUC;
        string country;
        string name;
        bool gender;
        private string button;
        public RangLists()
        {
            InitializeComponent();
        }

        private void RangLists_Load(object sender, EventArgs e)
        {
            flpYellowCard.Controls.Clear();
            flyGoal.Controls.Clear();
            flyVisitors.Controls.Clear();
            lblImeDrzave.Text = CheckSettings.LoadFavoriteCountry();
            name = CheckSettings.LoadFavoriteCountry();
            gender = CheckSettings.LoadGender();

            country = CheckSettings.LoadFavoriteCountry();

            LoadAllRangList();
        }
        private async void LoadAllRangList()
        {
            FileRepository fileRepository = new FileRepository();
            ApiRepository apiRepository = new ApiRepository();
            List<Match> matchList = new List<Match>();
            try
            {
                if (CheckSettings.LoadAPIFILESettings())
                {
                    matchList = await fileRepository.GetMatchesByFifaName(gender, name);
                }
                else
                {
                    matchList = await apiRepository.GetMatchesByFifaName(gender, name);
                }
                List<TeamEvent> events = GetEvents(matchList);
                List<string> players = GetPlayers(matchList);

                pLayerGoals = new List<PLayerGoalUC>();
                playerYellows = new List<PlayerYellowCardUC>();
                GetAllAttendace(matchList);

                players.ForEach(p =>
                {
                    int countgoal = 0;
                    int countyellowcards = 0;
                    events.ForEach(e =>
                    {
                        if (e.Player == p)
                        {
                            if (e.TypeOfEvent == "goal" || e.TypeOfEvent == "goal-penalty")
                            {
                                countgoal++;
                            }
                            if (e.TypeOfEvent == "yellow-card")
                            {
                                countyellowcards++;
                            }
                        }
                    });
                    pLayerGoals.Add(new PLayerGoalUC(p, countgoal));
                    playerYellows.Add(new PlayerYellowCardUC(p, countyellowcards));
                });
                //pLayerGoals.Sort((m1, m2) => m1.GetGoals().CompareTo(m2.GetGoals()));
                //playerYellows.Sort((m1, m2) => m1.GetYellowCards().CompareTo(m2.GetYellowCards()));
                pLayerGoals.Sort((m1, m2) => -m1.GetGoals().CompareTo(m2.GetGoals()));
                playerYellows.Sort((m1, m2) => -m1.GetYellowCards().CompareTo(m2.GetYellowCards()));
                flyGoal.Controls.AddRange(pLayerGoals.ToArray());
                flpYellowCard.Controls.AddRange(playerYellows.ToArray());
                lblLoading.Text = "";
                pbLoading.Visible = false;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private List<string> GetPlayers(List<Match> matches)
        {
            List<string> players = new List<string>();
            List<Player> startingElevent = null;
            List<Player> substitutes = null;
            bool gender = CheckSettings.LoadGender();
            foreach (Match match in matches)
            {
                if (match.HomeTeamCountry == country)
                {
                    startingElevent = match.HomeTeamStatistics.StartingEleven;
                    substitutes = match.HomeTeamStatistics.Substitutes;
                }
                else if (match.AwayTeamCountry == country)
                {
                    startingElevent = match.AwayTeamStatistics.StartingEleven;
                    substitutes = match.AwayTeamStatistics.Substitutes;
                }
            }

            startingElevent.ForEach(p => players.Add(p.FullName));
            substitutes.ForEach(p => players.Add(p.FullName));
            return players;
        }
        private List<TeamEvent> GetEvents(List<Match> matches)
        {
            List<TeamEvent> events = new List<TeamEvent>();
            foreach (var match in matches)
            {
                if (match.HomeTeamCountry == name)
                {
                    match.HomeTeamEvents.ForEach(e => events.Add(e));
                }
                else if (match.AwayTeamCountry == name)
                {
                    match.AwayTeamEvents.ForEach(e => events.Add(e));
                }
            }
            return events;
        }
        private void GetAllAttendace(List<Match> matches)
        {
            matchesUC = new List<MatchUC>();
            foreach (var match in matches)
            {
                if (match.HomeTeamCountry == name || match.AwayTeamCountry == name)
                {
                    matchesUC.Add(new MatchUC($"{match.HomeTeam} VS {match.AwayTeam}", match.Location, match.Attendance));
                }
            }
            //matchesUC.Sort((m1, m2) => m1.GetAttendance().CompareTo(m2.GetAttendance()));
            matchesUC.Sort((m1, m2) => -m1.GetAttendance().CompareTo(m2.GetAttendance()));
            flyVisitors.Controls.AddRange(matchesUC.ToArray());
        }
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Hide();
        }
        string nameOfButton;
        private void btnPrintYellowCard_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            nameOfButton = clickedButton.Name;
            printPreviewDialog.ShowDialog();
        }
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (nameOfButton == "btnPrintGoals")
            {
                PrintGoals(e);
            }
            else if (nameOfButton == "btnPrintYellowCard")
            {
                PrintYellowCards(e);
            }
            else if (nameOfButton == "btnPrintVisitors")
            {
                PrintAttendance(e);
            }
        }
        private int printPages = 0;
        private void PrintAttendance(PrintPageEventArgs e)
        {
            float dpiX = e.Graphics.DpiX;
            float dpiY = e.Graphics.DpiY;
            RectangleF rectangleF = e.PageSettings.PrintableArea;
            rectangleF.X = rectangleF.X * dpiX / 50;
            rectangleF.Y = rectangleF.Y * dpiY / 50;
            rectangleF.Width = rectangleF.Width * dpiX / 100;
            rectangleF.Height = rectangleF.Height * dpiY / 100;

            int numberOfPLayersPerPage = 5;
            int cuurentPlayerIndex = printPages * numberOfPLayersPerPage;
            int numberOfPlayerPerOneSpecificPage = 0;
            float top = rectangleF.Top;
            float y = top;
            while (cuurentPlayerIndex < matchesUC.Count &&
                    y + matchesUC[cuurentPlayerIndex].Height + matchesUC[cuurentPlayerIndex].Margin.Vertical <= top + rectangleF.Height &&
                    numberOfPlayerPerOneSpecificPage < numberOfPLayersPerPage)
            {
                Control player = matchesUC[cuurentPlayerIndex];
                Bitmap bitmap = new Bitmap(player.Width, player.Height);
                player.DrawToBitmap(bitmap, player.ClientRectangle);
                e.Graphics.DrawImage(bitmap, rectangleF.Left + player.Margin.Left, y + player.Margin.Top);
                y += player.Height + player.Margin.Vertical;

                cuurentPlayerIndex++;
                numberOfPlayerPerOneSpecificPage++;
            }
            if (cuurentPlayerIndex < matchesUC.Count)
            {
                e.HasMorePages = true;
                printPages++;
            }
            else
            {
                e.HasMorePages = false;
                printPages = 0;
            }
        }

        private void PrintYellowCards(PrintPageEventArgs e)
        {
            float dpiX = e.Graphics.DpiX;
            float dpiY = e.Graphics.DpiY;
            RectangleF rectangleF = e.PageSettings.PrintableArea;
            rectangleF.X = rectangleF.X * dpiX / 50;
            rectangleF.Y = rectangleF.Y * dpiY / 50;
            rectangleF.Width = rectangleF.Width * dpiX / 100;
            rectangleF.Height = rectangleF.Height * dpiY / 100;

            int numberOfPLayersPerPage = 5;
            int cuurentPlayerIndex = printPages * numberOfPLayersPerPage;
            int numberOfPlayerPerOneSpecificPage = 0;
            float top = rectangleF.Top;
            float y = top;
            while (cuurentPlayerIndex < playerYellows.Count &&
                    y + playerYellows[cuurentPlayerIndex].Height + playerYellows[cuurentPlayerIndex].Margin.Vertical <= top + rectangleF.Height &&
                    numberOfPlayerPerOneSpecificPage < numberOfPLayersPerPage)
            {
                Control player = playerYellows[cuurentPlayerIndex];
                Bitmap bitmap = new Bitmap(player.Width, player.Height);
                player.DrawToBitmap(bitmap, player.ClientRectangle);
                e.Graphics.DrawImage(bitmap, rectangleF.Left + player.Margin.Left, y + player.Margin.Top);
                y += player.Height + player.Margin.Vertical;

                cuurentPlayerIndex++;
                numberOfPlayerPerOneSpecificPage++;
            }
            if (cuurentPlayerIndex < playerYellows.Count)
            {
                e.HasMorePages = true;
                printPages++;
            }
            else
            {
                e.HasMorePages = false;
                printPages = 0;
            }
        }

        private void PrintGoals(PrintPageEventArgs e)
        {
            float dpiX = e.Graphics.DpiX;
            float dpiY = e.Graphics.DpiY;
            RectangleF rectangleF = e.PageSettings.PrintableArea;
            rectangleF.X = rectangleF.X * dpiX / 50;
            rectangleF.Y = rectangleF.Y * dpiY / 50;
            rectangleF.Width = rectangleF.Width * dpiX / 100;
            rectangleF.Height = rectangleF.Height * dpiY / 100;
            int numberOfPLayersPerPage = 5;
            int cuurentPlayerIndex = printPages * numberOfPLayersPerPage;
            int numberOfPlayerPerOneSpecificPage = 0;
            float top = rectangleF.Top;
            float y = top;
            while (cuurentPlayerIndex < pLayerGoals.Count &&
                    y + pLayerGoals[cuurentPlayerIndex].Height + pLayerGoals[cuurentPlayerIndex].Margin.Vertical <= top + rectangleF.Height &&
                    numberOfPlayerPerOneSpecificPage < numberOfPLayersPerPage)
            {
                Control player = pLayerGoals[cuurentPlayerIndex];
                Bitmap bitmap = new Bitmap(player.Width, player.Height);
                player.DrawToBitmap(bitmap, player.ClientRectangle);
                e.Graphics.DrawImage(bitmap, rectangleF.Left + player.Margin.Left, y + player.Margin.Top);
                y += player.Height + player.Margin.Vertical;

                cuurentPlayerIndex++;
                numberOfPlayerPerOneSpecificPage++;
            }
            if (cuurentPlayerIndex < pLayerGoals.Count)
            {
                e.HasMorePages = true;
                printPages++;
            }
            else
            {
                e.HasMorePages = false;
                printPages = 0;
            }
        }
        private void PrintDocument_EndPrint(object sender, PrintEventArgs e)
        {

        }
    }
}
