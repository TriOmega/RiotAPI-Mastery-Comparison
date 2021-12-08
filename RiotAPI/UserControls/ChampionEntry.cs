using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RiotAPI.UserControls
{
    public partial class ChampionEntry : UserControl
    {
        private ChampionList ChampionNameList { get; set; }
        public ChampionEntry(long masteryScore, long championID)
        {
            InitializeComponent();

            string championFileData = File.ReadAllText("D:\\Documents\\Current_Work\\RiotAPI\\RiotAPI-Mastery-Comparison\\RiotAPI\\champion.json");
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
