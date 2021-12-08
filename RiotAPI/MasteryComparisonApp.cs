using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.SummonerV4;
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

        #region FirstSummonerInput
        private void firstSummonerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            //compareButton.Enabled = !string.IsNullOrEmpty(FirstSummonerID);
        }

        private void firstSummonerNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CheckSummonerNameInput(1);
            }
        }

        private void firstSummonerOKButton_Click(object sender, EventArgs e)
        {
            CheckSummonerNameInput(1);
        }

        private void secondSummonerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region SecondSummonerInput
        private void secondSummonerNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CheckSummonerNameInput(2);
            }
        }

        private void secondSummonerOKButton_Click(object sender, EventArgs e)
        {
            CheckSummonerNameInput(2);
        }
        #endregion

        private void CheckSummonerNameInput(int summonerValue)
        {
            if (summonerValue == 1)
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
            else if (summonerValue == 2)
            {
                if (!string.IsNullOrEmpty(SecondSummonerID))
                {
                    CompData.Summoner2 = CompData.ApiInstance.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, SecondSummonerID);
                    firstSummonerOutputLabel.Text = CompData.Summoner2.Name;
                }
                else
                {
                    MessageBox.Show("Valid name required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                throw new InvalidProgramException("Invalid summonerValue.");
            }
        }
    }
}
