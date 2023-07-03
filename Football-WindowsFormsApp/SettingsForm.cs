using Data_Access_Layer;
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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            string[] settings = null;
            try
            {
                settings = CheckSettings.LoadSettings();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            label1.Text = settings[0];
            label3.Text = settings[1];
        }
        private void btnSpremiPromjene_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni ?", "Upozorenje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                string gender;
                string apifile;
                if (rbMuškiMale.Checked) gender = rbMuškiMale.Text;
                else gender = rbŽenskoFemale.Text;
                if (rbAPI.Checked) apifile = rbAPI.Text;
                else apifile = rbFILE.Text;
                try
                {
                    CheckSettings.SaveSettings(gender, apifile);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Hide();
            }

        }
    }
}
