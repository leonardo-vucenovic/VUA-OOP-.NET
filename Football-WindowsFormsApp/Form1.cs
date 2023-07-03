using Data_Access_Layer;
using System.Drawing.Printing;
using System.Web;

namespace Football_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        MainForm mainForm = new MainForm();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (CheckSettings.ExistSettings())
                {
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNastaviContinue_Click(object sender, EventArgs e)
        {
            string gender;
            string apifile;
            if (rbMuökiMale.Checked) gender = rbMuökiMale.Text;
            else gender = rbéenskoFemale.Text;
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
            mainForm.Show();
            mainForm.BringToFront();

        }
    }
}