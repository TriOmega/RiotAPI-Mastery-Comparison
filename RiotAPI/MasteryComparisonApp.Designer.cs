
namespace RiotAPI
{
    partial class MasteryComparisonApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel inputPanel;
            System.Windows.Forms.Panel secondSummonerInputPanel;
            System.Windows.Forms.Label secondSummonerInputLabel;
            System.Windows.Forms.Label inputPanelLabel;
            System.Windows.Forms.Panel firstSummonerInputPanel;
            System.Windows.Forms.Label firstSummonerInputLabel;
            this.secondSummonerOKButton = new System.Windows.Forms.Button();
            this.secondSummonerNameTextBox = new System.Windows.Forms.TextBox();
            this.compareButton = new System.Windows.Forms.Button();
            this.firstSummonerOKButton = new System.Windows.Forms.Button();
            this.firstSummonerNameTextBox = new System.Windows.Forms.TextBox();
            this.firstSummonerOutputLabel = new System.Windows.Forms.Label();
            this.secondSummonerOutputLabel = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            inputPanel = new System.Windows.Forms.Panel();
            secondSummonerInputPanel = new System.Windows.Forms.Panel();
            secondSummonerInputLabel = new System.Windows.Forms.Label();
            inputPanelLabel = new System.Windows.Forms.Label();
            firstSummonerInputPanel = new System.Windows.Forms.Panel();
            firstSummonerInputLabel = new System.Windows.Forms.Label();
            inputPanel.SuspendLayout();
            secondSummonerInputPanel.SuspendLayout();
            firstSummonerInputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputPanel
            // 
            inputPanel.Controls.Add(secondSummonerInputPanel);
            inputPanel.Controls.Add(inputPanelLabel);
            inputPanel.Controls.Add(this.compareButton);
            inputPanel.Controls.Add(firstSummonerInputPanel);
            inputPanel.Location = new System.Drawing.Point(13, 13);
            inputPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            inputPanel.Name = "inputPanel";
            inputPanel.Size = new System.Drawing.Size(808, 192);
            inputPanel.TabIndex = 5;
            // 
            // secondSummonerInputPanel
            // 
            secondSummonerInputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            secondSummonerInputPanel.Controls.Add(this.secondSummonerOKButton);
            secondSummonerInputPanel.Controls.Add(this.secondSummonerNameTextBox);
            secondSummonerInputPanel.Controls.Add(secondSummonerInputLabel);
            secondSummonerInputPanel.Location = new System.Drawing.Point(415, 44);
            secondSummonerInputPanel.Margin = new System.Windows.Forms.Padding(10);
            secondSummonerInputPanel.Name = "secondSummonerInputPanel";
            secondSummonerInputPanel.Size = new System.Drawing.Size(383, 117);
            secondSummonerInputPanel.TabIndex = 5;
            // 
            // secondSummonerOKButton
            // 
            this.secondSummonerOKButton.Location = new System.Drawing.Point(154, 80);
            this.secondSummonerOKButton.Name = "secondSummonerOKButton";
            this.secondSummonerOKButton.Size = new System.Drawing.Size(75, 23);
            this.secondSummonerOKButton.TabIndex = 2;
            this.secondSummonerOKButton.Text = "OK";
            this.secondSummonerOKButton.UseVisualStyleBackColor = true;
            // 
            // secondSummonerNameTextBox
            // 
            this.secondSummonerNameTextBox.Location = new System.Drawing.Point(10, 47);
            this.secondSummonerNameTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.secondSummonerNameTextBox.Name = "secondSummonerNameTextBox";
            this.secondSummonerNameTextBox.Size = new System.Drawing.Size(363, 20);
            this.secondSummonerNameTextBox.TabIndex = 1;
            // 
            // secondSummonerInputLabel
            // 
            secondSummonerInputLabel.AutoSize = true;
            secondSummonerInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            secondSummonerInputLabel.Location = new System.Drawing.Point(106, 10);
            secondSummonerInputLabel.Margin = new System.Windows.Forms.Padding(10);
            secondSummonerInputLabel.Name = "secondSummonerInputLabel";
            secondSummonerInputLabel.Size = new System.Drawing.Size(169, 17);
            secondSummonerInputLabel.TabIndex = 0;
            secondSummonerInputLabel.Text = "Second Summoner Name";
            // 
            // inputPanelLabel
            // 
            inputPanelLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            inputPanelLabel.AutoSize = true;
            inputPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            inputPanelLabel.Location = new System.Drawing.Point(320, 5);
            inputPanelLabel.Margin = new System.Windows.Forms.Padding(5);
            inputPanelLabel.Name = "inputPanelLabel";
            inputPanelLabel.Size = new System.Drawing.Size(169, 24);
            inputPanelLabel.TabIndex = 3;
            inputPanelLabel.Text = "Summoner Names";
            inputPanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // compareButton
            // 
            this.compareButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.compareButton.Location = new System.Drawing.Point(0, 169);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(808, 23);
            this.compareButton.TabIndex = 1;
            this.compareButton.Text = "Compare";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // firstSummonerInputPanel
            // 
            firstSummonerInputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            firstSummonerInputPanel.Controls.Add(this.firstSummonerOKButton);
            firstSummonerInputPanel.Controls.Add(this.firstSummonerNameTextBox);
            firstSummonerInputPanel.Controls.Add(firstSummonerInputLabel);
            firstSummonerInputPanel.Location = new System.Drawing.Point(10, 44);
            firstSummonerInputPanel.Margin = new System.Windows.Forms.Padding(10);
            firstSummonerInputPanel.Name = "firstSummonerInputPanel";
            firstSummonerInputPanel.Size = new System.Drawing.Size(383, 117);
            firstSummonerInputPanel.TabIndex = 4;
            // 
            // firstSummonerOKButton
            // 
            this.firstSummonerOKButton.Location = new System.Drawing.Point(154, 80);
            this.firstSummonerOKButton.Name = "firstSummonerOKButton";
            this.firstSummonerOKButton.Size = new System.Drawing.Size(75, 23);
            this.firstSummonerOKButton.TabIndex = 2;
            this.firstSummonerOKButton.Text = "OK";
            this.firstSummonerOKButton.UseVisualStyleBackColor = true;
            // 
            // firstSummonerNameTextBox
            // 
            this.firstSummonerNameTextBox.Location = new System.Drawing.Point(10, 47);
            this.firstSummonerNameTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.firstSummonerNameTextBox.Name = "firstSummonerNameTextBox";
            this.firstSummonerNameTextBox.Size = new System.Drawing.Size(363, 20);
            this.firstSummonerNameTextBox.TabIndex = 1;
            this.firstSummonerNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // firstSummonerInputLabel
            // 
            firstSummonerInputLabel.AutoSize = true;
            firstSummonerInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstSummonerInputLabel.Location = new System.Drawing.Point(117, 10);
            firstSummonerInputLabel.Margin = new System.Windows.Forms.Padding(10);
            firstSummonerInputLabel.Name = "firstSummonerInputLabel";
            firstSummonerInputLabel.Size = new System.Drawing.Size(148, 17);
            firstSummonerInputLabel.TabIndex = 0;
            firstSummonerInputLabel.Text = "First Summoner Name";
            firstSummonerInputLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // firstSummonerOutputLabel
            // 
            this.firstSummonerOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstSummonerOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstSummonerOutputLabel.Location = new System.Drawing.Point(13, 218);
            this.firstSummonerOutputLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.firstSummonerOutputLabel.Name = "firstSummonerOutputLabel";
            this.firstSummonerOutputLabel.Size = new System.Drawing.Size(393, 30);
            this.firstSummonerOutputLabel.TabIndex = 0;
            this.firstSummonerOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.firstSummonerOutputLabel.Click += new System.EventHandler(this.firstSummonerLabel_Click);
            // 
            // secondSummonerOutputLabel
            // 
            this.secondSummonerOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondSummonerOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondSummonerOutputLabel.Location = new System.Drawing.Point(428, 218);
            this.secondSummonerOutputLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.secondSummonerOutputLabel.Name = "secondSummonerOutputLabel";
            this.secondSummonerOutputLabel.Size = new System.Drawing.Size(393, 30);
            this.secondSummonerOutputLabel.TabIndex = 8;
            this.secondSummonerOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(13, 251);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(393, 647);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(428, 251);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(393, 647);
            this.listView3.TabIndex = 7;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(412, 273);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(10, 600);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MasteryComparisonApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 911);
            this.Controls.Add(this.secondSummonerOutputLabel);
            this.Controls.Add(this.firstSummonerOutputLabel);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(inputPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MasteryComparisonApp";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Leage of Legends - Summoner Mastery Comparison";
            inputPanel.ResumeLayout(false);
            inputPanel.PerformLayout();
            secondSummonerInputPanel.ResumeLayout(false);
            secondSummonerInputPanel.PerformLayout();
            firstSummonerInputPanel.ResumeLayout(false);
            firstSummonerInputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox firstSummonerNameTextBox;
        private System.Windows.Forms.Button secondSummonerOKButton;
        private System.Windows.Forms.TextBox secondSummonerNameTextBox;
        private System.Windows.Forms.Button firstSummonerOKButton;
        private System.Windows.Forms.Label firstSummonerOutputLabel;
        private System.Windows.Forms.Label secondSummonerOutputLabel;
    }
}

