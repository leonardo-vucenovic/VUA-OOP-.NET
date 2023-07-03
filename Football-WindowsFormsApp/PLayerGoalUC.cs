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
    public partial class PLayerGoalUC : UserControl
    {
        public PLayerGoalUC(string name, int goals)
        {
            InitializeComponent();
            lblImeiPrezime.Text = name;
            lblBrojGolova.Text = goals.ToString();
        }
        public int GetGoals()
        {
            return int.Parse(lblBrojGolova.Text);
        }
    }
}
