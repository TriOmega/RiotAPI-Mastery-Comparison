using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MingweiSamuel.Camille;
using RiotAPI.UserControls;

namespace RiotAPI
{
    public partial class MasteryComparisonApp : Form
    {
        public string FirstSummonerID
        {
            get
            {
                return firstSummonerNameTextBox.Text;
            }
            set
            {
                firstSummonerNameTextBox.Text = value;
            }
        }
        
        public string SecondSummonerID
        {
            get
            {
                return secondSummonerNameTextBox.Text;
            }
            set
            {
                secondSummonerNameTextBox.Text = value;
            }
        }

        private ComparisonData CompData { get; set; }

        public MasteryComparisonApp()
        {
            InitializeComponent();
            CompData = new ComparisonData(RiotApi.NewInstance("RGAPI-e0aa5040-e568-4e0e-8873-a44066bb97bd"));
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            ChampionEntry[] championEntries = new ChampionEntry[5];
            for (int i = 0; i < championEntries.Length; i++)
            {
                championEntries[i] = new ChampionEntry();
                firstSummonerFlowPanel.Controls.Add(championEntries[i]);
            }
        }

        private void firstSummonerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            compareButton.Enabled = !string.IsNullOrEmpty(FirstSummonerID);
        }

        private void firstSummonerOKButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FirstSummonerID))
            {
                CompData.Summoner1 = CompData.ApiInstance.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, FirstSummonerID);
                firstSummonerOutputLabel.Text = CompData.Summoner1.Name;
            }
            else
            {
                MessageBox.Show("Valid name required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void secondSummonerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondSummonerOKButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SecondSummonerID))
            {
                CompData.Summoner2 = CompData.ApiInstance.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, SecondSummonerID);
                secondSummonerOutputLabel.Text = CompData.Summoner2.Name;
            }
            else
            {
                MessageBox.Show("Valid name required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
