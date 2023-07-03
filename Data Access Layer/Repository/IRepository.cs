using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repository
{
    public interface IRepository
    {
        Task<List<Team>> GetTeams(bool gender);
        Task<List<Result>> GetResults(bool gender);
        Task<List<Match>> GetMatches(bool gender);
        Task<List<Match>> GetMatchesByFifaName(bool gender, string name);
    }
}
