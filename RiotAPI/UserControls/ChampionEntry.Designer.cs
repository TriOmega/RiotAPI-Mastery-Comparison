
namespace RiotAPI.UserControls
{
    partial class ChampionEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.championPictureBox = new System.Windows.Forms.PictureBox();
            this.championNameLabel = new System.Windows.Forms.Label();
            this.championMasteryScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.championPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // championPictureBox
            // 
            this.championPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.championPictureBox.Location = new System.Drawing.Point(10, 10);
            this.championPictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.championPictureBox.Name = "championPictureBox";
            this.championPictureBox.Size = new System.Drawing.Size(120, 120);
            this.championPictureBox.TabIndex = 0;
            this.championPictureBox.TabStop = false;
            // 
            // championNameLabel
            // 
            this.championNameLabel.AutoSize = true;
            this.championNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.championNameLabel.Location = new System.Drawing.Point(145, 30);
            this.championNameLabel.Margin = new System.Windows.Forms.Padding(5, 30, 5, 5);
            this.championNameLabel.Name = "championNameLabel";
            this.championNameLabel.Size = new System.Drawing.Size(155, 24);
            this.championNameLabel.TabIndex = 1;
            this.championNameLabel.Text = "DefaultNameText";
            // 
            // championMasteryScoreLabel
            // 
            this.championMasteryScoreLabel.AutoSize = true;
            this.championMasteryScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.championMasteryScoreLabel.Location = new System.Drawing.Point(145, 86);
            this.championMasteryScoreLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 30);
            this.championMasteryScoreLabel.Name = "championMasteryScoreLabel";
            this.championMasteryScoreLabel.Size = new System.Drawing.Size(201, 24);
            this.championMasteryScoreLabel.TabIndex = 2;
            this.championMasteryScoreLabel.Text = "Mastery Points: xxxxxx";
            // 
            // ChampionEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.championMasteryScoreLabel);
            this.Controls.Add(this.championNameLabel);
            this.Controls.Add(this.championPictureBox);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ChampionEntry";
            this.Size = new System.Drawing.Size(370, 140);
            ((System.ComponentModel.ISupportInitialize)(this.championPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox championPictureBox;
        private System.Windows.Forms.Label championNameLabel;
        private System.Windows.Forms.Label championMasteryScoreLabel;
    }
}
