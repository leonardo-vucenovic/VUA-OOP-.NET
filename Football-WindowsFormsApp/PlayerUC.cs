using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Football_WindowsFormsApp
{
    public partial class PlayerUC : UserControl
    {
        public bool SelectedPlayer { get; set; }
        public Player Player { get; set; }
        public PlayerUC(Player player)
        {
            InitializeComponent();
            Player = player;
            SetData(player);
        }
        private void SetData(Player player)
        {
            lblImeIPrezime.Text = player.FullName;
            lblBrojDresa.Text = player.ShirtNumber.ToString();
            lblPozicija.Text = player.Position.ToString();
            if (player.Captain == true) lblKapetan.Text = "C";
            else lblKapetan.Text = "";
        }
        private void pbSlikaIgraca_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Slike|*.jpg;*.png*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbSlikaIgraca.ImageLocation = openFileDialog.FileName;
            }
        }
        public void CreateStar()
        {
            pbNajdrazigrac.Visible = true;
        }
        public void RemoveStar()
        {
            pbNajdrazigrac.Visible = false;
        }
        internal void UnselecPlayer()
        {
            BackColor = Color.White;
            SelectedPlayer = false;
        }

        private void PlayerUC_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (BackColor == Color.White)
                {
                    BackColor = Color.Yellow;
                    SelectedPlayer = true;
                }
                else
                {
                    BackColor = Color.White;
                    SelectedPlayer = false;
                }
            }
            if (e.Button == MouseButtons.Left)
            {
                SelectedPlayer = true;
                BackColor = Color.Beige;
                PlayerUC player = sender as PlayerUC;
                player.DoDragDrop(this, DragDropEffects.Move);
            }
        }
    }
}
