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

namespace RiotAPI.UserControls
{
    public partial class ChampionEntry : UserControl
    {
        public ChampionEntry(long masteryScore)
        {
            InitializeComponent();

            string championFileData = File.ReadAllText("D:\\Documents\\Current_Work\\RiotAPI\\RiotAPI-Mastery-Comparison\\RiotAPI\\champion.json");

            championMasteryScoreLabel.Text = $"Master Points: {masteryScore}";
        }
    }
}
