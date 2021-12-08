using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MingweiSamuel.Camille;

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

        private ComparisonData CompData { get; set; }

        public MasteryComparisonApp()
        {
            InitializeComponent();
            CompData = new ComparisonData(RiotApi.NewInstance("RGAPI-e0aa5040-e568-4e0e-8873-a44066bb97bd"));
        }

        private void summonerIDTextBox1_TextChanged(object sender, EventArgs e)
        {
            compareButton.Enabled = !string.IsNullOrEmpty(FirstSummonerID);
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            CompData.Summoner1 = CompData.ApiInstance.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, FirstSummonerID);
            firstSummonerOutputLabel.Text = CompData.Summoner1.Name;
        }

        private void testTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstSummonerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
