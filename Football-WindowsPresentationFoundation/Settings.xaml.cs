using Data_Access_Layer;
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
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnSpremiPromjene_Click(object sender, RoutedEventArgs e)
        {
            string gender;
            string language;
            string apifile;
            string resolution;
            if (rbMuško.IsChecked == true) gender = rbMuško.Content.ToString();
            else gender = rbŽensko.Content.ToString();
            if (rbAPI.IsChecked == true) apifile = rbAPI.Content.ToString();
            else apifile = rbFile.Content.ToString();
            if (rbSmall.IsChecked == true) resolution = rbSmall.Content.ToString();
            else if (rbBig.IsChecked == true) resolution = rbBig.Content.ToString();
            else resolution = rbFullScreen.Content.ToString();
            try
            {
                CheckSettings.SaveSettingsWPF(gender, apifile, resolution);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Football football = new Football();
            football.Show();
            this.Close();
        }
    }
}
