using System;
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
            using (ApiKeyForm apiKeyForm = new ApiKeyForm())
            {
                var result = apiKeyForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CompData = new ComparisonData(RiotApi.NewInstance(apiKeyForm.APIKeyText));
                }
                else if (result == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            firstSummonerFlowPanel.Controls.Clear();
            secondSummonerFlowPanel.Controls.Clear();
            CompData.CompareSummonerMasteryLists();
            foreach(var entry in CompData.Summoner1ComparedMasteryList)
            {
                firstSummonerFlowPanel.Controls.Add(new ChampionEntry(entry.ChampionPoints, entry.ChampionId));
            }
            foreach (var entry in CompData.Summoner2ComparedMasteryList)
            {
                secondSummonerFlowPanel.Controls.Add(new ChampionEntry(entry.ChampionPoints, entry.ChampionId));
            }
        }

#region FirstSummonerInput
        private void firstSummonerNameTextBox_TextChanged(object sender, EventArgs e)
        {

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
#endregion

#region SecondSummonerInput
        private void secondSummonerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

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

        private void apiKeyButton_Click(object sender, EventArgs e)
        {
            using (ApiKeyForm apiKeyForm = new ApiKeyForm())
            {
                if (apiKeyForm.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }

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
                    secondSummonerOutputLabel.Text = CompData.Summoner2.Name;
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
