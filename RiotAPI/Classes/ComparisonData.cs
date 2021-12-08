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

        List<ChampionMastery> Summoner1ChampionMasteries = new List<ChampionMastery>();
        List<ChampionMastery> Summoner2ChampionMasteries = new List<ChampionMastery>();

        public Summoner Summoner1
        {
            get => _summoner1;
            set 
            {
                _summoner1 = value;
                ChampionMastery[] championMasteries = ApiInstance.ChampionMasteryV4.GetAllChampionMasteries(Region.NA, Summoner1.Id);
                foreach (ChampionMastery entry in championMasteries)
                {
                    Summoner1ChampionMasteries.Add(entry);
                }
            }
        }

        public Summoner Summoner2
        {
            get => _summoner2;
            set
            {
                _summoner2 = value;
                ChampionMastery[] championMasteries = ApiInstance.ChampionMasteryV4.GetAllChampionMasteries(Region.NA, Summoner2.Id);
                foreach (ChampionMastery entry in championMasteries)
                {
                    Summoner2ChampionMasteries.Add(entry);
                }
            }
        }

        //List<ChampionMastery> summoner1masteries, List<ChampionMastery> summoner2masteries
        public void CompareSummonerMasteryLists ()
        {
            //Summoner1ChampionMasteries.Where(Summoner1ChampionMasteries.Exists(Summoner1ChampionMasteries))
        }

        private Summoner _summoner1;
        private Summoner _summoner2;
    }
}
