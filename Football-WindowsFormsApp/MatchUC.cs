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
    public partial class MatchUC : UserControl
    {
        public MatchUC(string teams, string location, long people)
        {
            InitializeComponent();
            lblHomeVsAway.Text = teams;
            lblImeStadiona.Text = location;
            lblNumberOfAttendance.Text = people.ToString();
        }

        public int GetAttendance()
        {
            return int.Parse(lblNumberOfAttendance.Text);
        }
    }
}
