using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RiotAPI.UserControls
{
    public partial class ChampionEntry : UserControl
    {
        private static readonly Uri championJSON = new Uri("http://ddragon.leagueoflegends.com/cdn/11.24.1/data/en_US/champion.json");
        private ChampionList ChampionNameList { get; set; }
        public HttpClient Client { get; }

        public ChampionEntry(long masteryScore, long championID)
        {
            InitializeComponent();

            Client = new HttpClient
            {
                MaxResponseContentBufferSize = 256000
            };
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //var query = Http

           string championFileData = File.ReadAllText("D:\\Documents\\Current_Work\\RiotAPI\\RiotAPI-Mastery-Comparison\\RiotAPI\\champion.json");
            //var query = 
            
            ChampionNameList = JsonConvert.DeserializeObject<ChampionList>(championFileData);

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
