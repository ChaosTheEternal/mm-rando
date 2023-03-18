namespace MMR.UI.Forms
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
            lAboutText = new System.Windows.Forms.Label();
            lAboutTitle = new System.Windows.Forms.Label();
            discordLinkLabel = new System.Windows.Forms.LinkLabel();
            SuspendLayout();
            // 
            // lAboutText
            // 
            lAboutText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lAboutText.Location = new System.Drawing.Point(31, 38);
            lAboutText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lAboutText.Name = "lAboutText";
            lAboutText.Size = new System.Drawing.Size(359, 246);
            lAboutText.TabIndex = 0;
            lAboutText.Text = resources.GetString("lAboutText.Text");
            lAboutText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lAboutTitle
            // 
            lAboutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lAboutTitle.Location = new System.Drawing.Point(0, 1);
            lAboutTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lAboutTitle.Name = "lAboutTitle";
            lAboutTitle.Size = new System.Drawing.Size(419, 31);
            lAboutTitle.TabIndex = 1;
            lAboutTitle.Text = "Majora's Mask Randomizer";
            lAboutTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // discordLinkLabel
            // 
            discordLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            discordLinkLabel.AutoSize = true;
            discordLinkLabel.Location = new System.Drawing.Point(126, 148);
            discordLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            discordLinkLabel.Name = "discordLinkLabel";
            discordLinkLabel.Size = new System.Drawing.Size(157, 15);
            discordLinkLabel.TabIndex = 2;
            discordLinkLabel.TabStop = true;
            discordLinkLabel.Text = "https://discord.gg/8qbreUM";
            discordLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            discordLinkLabel.LinkClicked += discordLinkLabel_LinkClicked;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(419, 293);
            Controls.Add(discordLinkLabel);
            Controls.Add(lAboutTitle);
            Controls.Add(lAboutText);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "AboutForm";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lAboutText;
        private System.Windows.Forms.Label lAboutTitle;
        private System.Windows.Forms.LinkLabel discordLinkLabel;
    }
}