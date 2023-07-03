using Data_Access_Layer.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repository
{
    public class ApiRepository : IRepository
    {
        private const string PATH_MATCHES_MAN = "https://worldcup-vua.nullbit.hr/men/matches";
        private const string PATH_MATCHES_WOMEN = "https://worldcup-vua.nullbit.hr/women/matches";
        private const string PATH_TEAMS_MAN = "https://worldcup-vua.nullbit.hr/men/teams";
        private const string PATH_TEAMS_WOMEN = "https://worldcup-vua.nullbit.hr/women/teams";
        private const string PATH_RESULT_MAN = "https://worldcup-vua.nullbit.hr/men/teams/results";
        private const string PATH_RESULT_WOMEN = "https://worldcup-vua.nullbit.hr/women/teams/results";
        public Task<List<Match>> GetMatches(bool gender)
        {
            return Task.Run(async () =>
            {
                var endpoint = gender ? PATH_MATCHES_MAN : PATH_MATCHES_WOMEN;
                var apiClient = new RestClient(endpoint);
                var apiResult = await apiClient.ExecuteAsync<List<Match>>(new RestRequest());
                return JsonConvert.DeserializeObject<List<Match>>(apiResult.Content);
            });
        }
        public Task<List<Match>> GetMatchesByFifaName(bool gender, string name)
        {
            return Task.Run(async () =>
            {
                var endpoint = gender ? PATH_MATCHES_MAN : PATH_MATCHES_WOMEN;
                var fullendpoint = $"{endpoint}/{name}";
                var apiClient = new RestClient(endpoint);
                var apiResult = await apiClient.ExecuteAsync<List<Match>>(new RestRequest());
                return JsonConvert.DeserializeObject<List<Match>>(apiResult.Content);
            });
        }
        public Task<List<Result>> GetResults(bool gender)
        {
            return Task.Run(async () =>
            {
                var endpoint = gender ? PATH_RESULT_MAN : PATH_RESULT_WOMEN;
                var apiClient = new RestClient(endpoint);
                var apiResult = await apiClient.ExecuteAsync<List<Result>>(new RestRequest());
                return JsonConvert.DeserializeObject<List<Result>>(apiResult.Content);
            });
        }
        public Task<List<Team>> GetTeams(bool gender)
        {
            return Task.Run(async () =>
            {
                var endpoint = gender ? PATH_TEAMS_MAN : PATH_TEAMS_WOMEN;
                var apiClient = new RestClient(endpoint);
                var apiResult = await apiClient.ExecuteAsync<List<Team>>(new RestRequest());
                return JsonConvert.DeserializeObject<List<Team>>(apiResult.Content);
            });
        }

    }
}
