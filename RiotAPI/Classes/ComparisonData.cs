using System.Collections.Generic;
using System.Linq;
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

        private Dictionary<long, ChampionMastery> Summoner1ChampionMasteries = new Dictionary<long, ChampionMastery>();
        private Dictionary<long, ChampionMastery> Summoner2ChampionMasteries = new Dictionary<long, ChampionMastery>();

        public Summoner Summoner1
        {
            get => _summoner1;
            set 
            {
                _summoner1 = value;
                ChampionMastery[] championMasteries = ApiInstance.ChampionMasteryV4.GetAllChampionMasteries(Region.NA, Summoner1.Id);
                foreach (ChampionMastery entry in championMasteries)
                {
                    Summoner1ChampionMasteries.Add(entry.ChampionId, entry);
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
                    Summoner2ChampionMasteries.Add(entry.ChampionId, entry);
                }
            }
        }

        public List<ChampionMastery> Summoner1ComparedMasteryList = new List<ChampionMastery>();
        public List<ChampionMastery> Summoner2ComparedMasteryList = new List<ChampionMastery>();

        public void CompareSummonerMasteryLists ()
        {

            var query = Summoner1ChampionMasteries.Where(champion => Summoner2ChampionMasteries.ContainsKey(champion.Key));
            
            foreach (var champion in query)
            {
                Summoner1ComparedMasteryList.Add(champion.Value);
            }

            query = Summoner2ChampionMasteries.Where(champion => Summoner1ChampionMasteries.ContainsKey(champion.Key));
            foreach (var champion in query)
            {
                Summoner2ComparedMasteryList.Add(champion.Value);
            }

            query = Summoner1ChampionMasteries.Where(champion => !Summoner2ChampionMasteries.ContainsKey(champion.Key));

            foreach (var champion in query)
            {
                Summoner1ComparedMasteryList.Add(champion.Value);
            }

            query = Summoner2ChampionMasteries.Where(champion => !Summoner1ChampionMasteries.ContainsKey(champion.Key));
            foreach (var champion in query)
            {
                Summoner2ComparedMasteryList.Add(champion.Value);
            }
        }

        private Summoner _summoner1;
        private Summoner _summoner2;
    }
}
