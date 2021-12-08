using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.SummonerV4;
using MingweiSamuel.Camille.ChampionMasteryV4;

namespace RiotAPI
{
    class ComparisonData
    {
        public ComparisonData(RiotApi riotApi)
        {
            ApiInstance = riotApi;
        }
        
        public RiotApi ApiInstance { get; set; }

        public Summoner Summoner1
        {
            get => _summoner1;
            set => _summoner1 = value;
        }
        public Summoner Summoner2 { get; set; }

        private Summoner _summoner1;

    }
}
