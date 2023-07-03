using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_WindowsFormsApp
{
    public partial class PlayerYellowCardUC : UserControl
    {
        public PlayerYellowCardUC(string fullname, int yellowCards)
        {
            InitializeComponent();

            lblImeiPrezime.Text = fullname;
            lblBrojZutihKartona.Text = yellowCards.ToString();
        }
        public int GetYellowCards()
        {
            return int.Parse(lblBrojZutihKartona.Text);
        }
    }
}
