using Data_Access_Layer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class CheckSettings
    {
        private const string PATH_TEAMS_MAN = "..\\..\\..\\..\\..\\LeonardoVucenovicFIFA\\Data Access Layer\\JSON\\men\\teams.json";
        private const string PATH_TEAMS_WOMEN = "..\\..\\..\\..\\..\\LeonardoVucenovicFIFA\\Data Access Layer\\JSON\\women\\teams.json";

        private const string PATHSETTINGS = "Settings.txt";
        private const string PATHSETTINGSWPF = "SettingsWPF.txt";
        private const string PATHFAVORITECOUNTRY = "FavoriteCountry.txt";
        public static bool ExistSettings()
        {
            if (File.Exists(PATHSETTINGS))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool FileFavoriteCountryExists()
        {
            if (File.Exists(PATHFAVORITECOUNTRY))
            {
                return true;
            }
            return false;
        }
        public static void SaveSettings(string gender, string apijson)
        {
            File.WriteAllText(PATHSETTINGS, $"{gender}{Environment.NewLine}{apijson}");
        }
        public static string[] LoadSettings()
        {
            string[] data = File.ReadAllLines(PATHSETTINGS);
            return data;
        }
        public static bool LoadGender()
        {
            string[] data = LoadSettings();
            string gender = data[0];
            if (gender == "Muško-Male")
            {
                return true;
            }
            return false;
        }
        public static bool LoadAPIFILESettings()
        {
            string[] settings = LoadSettings();
            if (settings[1] == "FILE")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void SaveFavoriteCountry(string country)
        {
            File.WriteAllText(PATHFAVORITECOUNTRY, country);
        }
        public static string LoadFavoriteCountry()
        {
            string favoritecountry = File.ReadAllText(PATHFAVORITECOUNTRY);
            return favoritecountry;
        }
        public static string CatchFifaCode(bool gender, string country)
        {
            string filePath = gender ? PATH_TEAMS_MAN : PATH_TEAMS_WOMEN;
            var json = File.ReadAllText(filePath);
            var teams = JsonConvert.DeserializeObject<List<Team>>(json);
            foreach (Team item in teams)
            {
                if (item.Country == country)
                {
                    return item.FifaCode;
                }
            }
            return null;
        }
        public static void SaveSettingsWPF(string gender, string apijson, string resolutin)
        {
            File.WriteAllText(PATHSETTINGSWPF, $"{gender}{Environment.NewLine}{apijson}{Environment.NewLine}{resolutin}");
        }
        public static string[] LoadSettingsWPF()
        {
            string[] data = null;
            data = File.ReadAllLines(PATHSETTINGSWPF);
            return data;
        }
        public static bool LoadGenderWPF()
        {
            string[] data = LoadSettingsWPF();
            string gender = data[0];
            if (gender == "Muško-Male")
            {
                return true;
            }
            return false;
        }
        public static bool LoadAPIFILESettingsWPF()
        {
            string[] settings = LoadSettingsWPF();
            if (settings[1] == "File")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string LoadResolutionWPF()
        {
            string[] settings = LoadSettingsWPF();
            return settings[2];
        }
    }
}
