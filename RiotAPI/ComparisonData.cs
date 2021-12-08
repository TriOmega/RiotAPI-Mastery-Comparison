using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.SummonerV4;

namespace RiotAPI
{
    class ComparisonData
    {
        //public ComparisonData()
        //{
        //    var myApi = RiotApi.NewInstance("RGAPI-e0aa5040-e568-4e0e-8873-a44066bb97bd");
        //}
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
