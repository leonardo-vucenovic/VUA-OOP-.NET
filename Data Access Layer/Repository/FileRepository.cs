using Data_Access_Layer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repository
{
    public class FileRepository : IRepository
    {
        /*
        private const string JSON_FILES_PATH = "C:\\Users\\Leonardo\\Desktop\\VUA-OOP .NET\\Data Access Layer\\JSON\\men\\teams.json";
        private static readonly string PATH_TEAMS_MAN = Path.Combine(JSON_FILES_PATH, "men", "teams.json");
        private static readonly string PATH_TEAMS_WOMEN = Path.Combine(JSON_FILES_PATH, "women", "teams.json");
        private static readonly string PATH_MATCHES_MAN = Path.Combine(JSON_FILES_PATH, "men", "matches.json");
        private static readonly string PATH_MATCHES_WOMEN = Path.Combine(JSON_FILES_PATH, "women", "matches.json");
        private static readonly string PATH_RESULT_MEN = Path.Combine(JSON_FILES_PATH, "men", "result.json");
        private static readonly string PATH_RESULT_WOMEN = Path.Combine(JSON_FILES_PATH, "women", "result.json");
        private static readonly string PATH_GROUP_RESULT_MEN = Path.Combine(JSON_FILES_PATH, "women", "group_result.json");
        private static readonly string PATH_GROUP_RESULT_WOMEN = Path.Combine(JSON_FILES_PATH, "women", "group_result.json");
        */
        private const string PATH_TEAMS_MAN = "C:\\Users\\Leonardo\\Desktop\\VUA-OOP .NET\\Data Access Layer\\JSON\\men\\teams.json";
        private const string PATH_TEAMS_WOMEN = "C:\\Users\\Leonardo\\Desktop\\VUA-OOP .NET\\Data Access Layer\\JSON\\women\\teams.json";
        private const string PATH_MATCHES_MAN = "C:\\Users\\Leonardo\\Desktop\\VUA-OOP .NET\\Data Access Layer\\JSON\\men\\matches.json";
        private const string PATH_MATCHES_WOMEN = "C:\\Users\\Leonardo\\Desktop\\VUA-OOP .NET\\Data Access Layer\\JSON\\women\\matches.json";
        private const string PATH_RESULT_MEN = "C:\\Users\\Leonardo\\Desktop\\VUA-OOP .NET\\Data Access Layer\\JSON\\men\\results.json";
        private const string PATH_RESULT_WOMEN = "C:\\Users\\Leonardo\\Desktop\\VUA-OOP .NET\\Data Access Layer\\JSON\\women\\results.json";
        private const string PATH_GROUP_RESULT_MEN = "C:\\Users\\Leonardo\\Desktop\\VUA-OOP .NET\\Data Access Layer\\JSON\\men\\group_results.json";
        private const string PATH_GROUP_RESULT_WOMEN = "C:\\Users\\Leonardo\\Desktop\\VUA-OOP .NET\\Data Access Layer\\JSON\\women\\group_results.json";
       
        public FileRepository() 
        {
            CreateFileIfNotExists();
        }
        private void CreateFileIfNotExists()
        {
            if (!File.Exists(PATH_TEAMS_MAN) || !File.Exists(PATH_TEAMS_WOMEN) ||
                !File.Exists(PATH_MATCHES_MAN) || !File.Exists(PATH_MATCHES_WOMEN) ||
                !File.Exists(PATH_RESULT_MEN) || !File.Exists(PATH_RESULT_WOMEN) ||
                !File.Exists(PATH_GROUP_RESULT_MEN) || !File.Exists(PATH_GROUP_RESULT_WOMEN))
            {
                throw new Exception("Some of JSON file does not exists!");
            }
        }
        public Task<List<Team>> GetTeams(bool gender)
        {
            string filePath = gender ? PATH_TEAMS_MAN : PATH_TEAMS_WOMEN;
            var json = File.ReadAllText(filePath);
            var teams = JsonConvert.DeserializeObject<List<Team>>(json);
            return Task.FromResult(teams);
        }
        public Task<List<Match>> GetMatches(bool gender)
        {
            string filePath = gender ? PATH_MATCHES_MAN : PATH_MATCHES_WOMEN;
            var json = File.ReadAllText(filePath);
            var matches = JsonConvert.DeserializeObject<List<Match>>(json);
            return Task.FromResult(matches);
        }
        public Task<List<Match>> GetMatchesByFifaName(bool gender, string name)
        {
            string filePath = gender ? PATH_MATCHES_MAN : PATH_MATCHES_WOMEN;
            var json = File.ReadAllText(filePath);
            var matches = JsonConvert.DeserializeObject<List<Match>>(json);
            var filteredMatches = matches.Where(m => m.HomeTeamCountry == name || m.AwayTeamCountry == name).ToList();
            return Task.FromResult(filteredMatches);
        }

        public Task<List<Result>> GetResults(bool gender)
        {
            string filePath = gender ? PATH_RESULT_MEN : PATH_RESULT_WOMEN;
            var json = File.ReadAllText(filePath);
            var results = JsonConvert.DeserializeObject<List<Result>>(json);
            return Task.FromResult(results);
        }

    }
}
