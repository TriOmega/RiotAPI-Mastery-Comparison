using System;
using System.Net;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RiotAPI.UserControls
{
    public partial class ChampionEntry : UserControl
    {
        private static readonly Uri championURI = new Uri("http://ddragon.leagueoflegends.com/cdn/11.24.1/data/en_US/champion.json");
        private ChampionList ChampionNameList { get; set; }
        public WebClient Client { get; }

        public ChampionEntry(long masteryScore, long championID)
        {
            InitializeComponent();

            Client = new WebClient();
            string championJSON = Client.DownloadString(championURI);
            ChampionNameList = JsonConvert.DeserializeObject<ChampionList>(championJSON);

            foreach (KeyValuePair<string, Champion> entry in ChampionNameList.Data)
            {
                if (entry.Value.Key == championID)
                {
                    championNameLabel.Text = entry.Value.Name;
                }
            }
            
            championMasteryScoreLabel.Text = $"Master Points: {masteryScore}";
        }
    }
}
