
namespace RiotAPI
{
    partial class ApiKeyForm
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
            System.Windows.Forms.Label newAPIKeyLabel;
            this.okButton = new System.Windows.Forms.Button();
            this.apiKeyInputTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            newAPIKeyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(133, 55);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // apiKeyInputTextBox
            // 
            this.apiKeyInputTextBox.Location = new System.Drawing.Point(16, 27);
            this.apiKeyInputTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.apiKeyInputTextBox.Name = "apiKeyInputTextBox";
            this.apiKeyInputTextBox.Size = new System.Drawing.Size(275, 20);
            this.apiKeyInputTextBox.TabIndex = 1;
            this.apiKeyInputTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.apiKeyInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.apiKeyInputTextBox_KeyDown);
            // 
            // newAPIKeyLabel
            // 
            newAPIKeyLabel.AutoSize = true;
            newAPIKeyLabel.Location = new System.Drawing.Point(12, 9);
            newAPIKeyLabel.Name = "newAPIKeyLabel";
            newAPIKeyLabel.Size = new System.Drawing.Size(48, 13);
            newAPIKeyLabel.TabIndex = 2;
            newAPIKeyLabel.Text = "API Key:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(214, 55);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ApiKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 86);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(newAPIKeyLabel);
            this.Controls.Add(this.apiKeyInputTextBox);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ApiKeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New API Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox apiKeyInputTextBox;
        private System.Windows.Forms.Button cancelButton;
    }
}