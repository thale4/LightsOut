namespace LightsOut
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.gameTitleLabel = new System.Windows.Forms.Label();
            this.programAuthorLabel = new System.Windows.Forms.Label();
            this.gameInformationLabel = new System.Windows.Forms.Label();
            this.lightbulbPictureBox = new System.Windows.Forms.PictureBox();
            this.aboutOkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lightbulbPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTitleLabel
            // 
            this.gameTitleLabel.AutoSize = true;
            this.gameTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitleLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.gameTitleLabel.Location = new System.Drawing.Point(66, 43);
            this.gameTitleLabel.Name = "gameTitleLabel";
            this.gameTitleLabel.Size = new System.Drawing.Size(157, 31);
            this.gameTitleLabel.TabIndex = 0;
            this.gameTitleLabel.Text = "Lights Out!";
            // 
            // programAuthorLabel
            // 
            this.programAuthorLabel.AutoSize = true;
            this.programAuthorLabel.Location = new System.Drawing.Point(145, 74);
            this.programAuthorLabel.Name = "programAuthorLabel";
            this.programAuthorLabel.Size = new System.Drawing.Size(78, 13);
            this.programAuthorLabel.TabIndex = 1;
            this.programAuthorLabel.Text = "By Trevor Hale";
            this.programAuthorLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // gameInformationLabel
            // 
            this.gameInformationLabel.AutoSize = true;
            this.gameInformationLabel.Location = new System.Drawing.Point(31, 164);
            this.gameInformationLabel.Name = "gameInformationLabel";
            this.gameInformationLabel.Size = new System.Drawing.Size(221, 13);
            this.gameInformationLabel.TabIndex = 2;
            this.gameInformationLabel.Text = "Turn all the lights out (black) to win the game!";
            // 
            // lightbulbPictureBox
            // 
            this.lightbulbPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("lightbulbPictureBox.Image")));
            this.lightbulbPictureBox.Location = new System.Drawing.Point(17, 48);
            this.lightbulbPictureBox.Name = "lightbulbPictureBox";
            this.lightbulbPictureBox.Size = new System.Drawing.Size(43, 39);
            this.lightbulbPictureBox.TabIndex = 3;
            this.lightbulbPictureBox.TabStop = false;
            // 
            // aboutOkButton
            // 
            this.aboutOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.aboutOkButton.Location = new System.Drawing.Point(101, 209);
            this.aboutOkButton.Name = "aboutOkButton";
            this.aboutOkButton.Size = new System.Drawing.Size(75, 23);
            this.aboutOkButton.TabIndex = 4;
            this.aboutOkButton.Text = "OK";
            this.aboutOkButton.UseVisualStyleBackColor = true;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.aboutOkButton);
            this.Controls.Add(this.lightbulbPictureBox);
            this.Controls.Add(this.gameInformationLabel);
            this.Controls.Add(this.programAuthorLabel);
            this.Controls.Add(this.gameTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.lightbulbPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameTitleLabel;
        private System.Windows.Forms.Label programAuthorLabel;
        private System.Windows.Forms.Label gameInformationLabel;
        private System.Windows.Forms.PictureBox lightbulbPictureBox;
        private System.Windows.Forms.Button aboutOkButton;
    }
}