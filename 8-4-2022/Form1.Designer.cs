
namespace _8_4_2022
{
    partial class Form1
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
            this.comboBoxHomeTeam = new System.Windows.Forms.ComboBox();
            this.comboBoxAwayTeam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHomeManager = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAwayManager = new System.Windows.Forms.Label();
            this.labelHomeCaptain = new System.Windows.Forms.Label();
            this.labelAwayCaptain = new System.Windows.Forms.Label();
            this.labelStadium = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelCapacity1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxHomeTeam
            // 
            this.comboBoxHomeTeam.FormattingEnabled = true;
            this.comboBoxHomeTeam.Location = new System.Drawing.Point(43, 51);
            this.comboBoxHomeTeam.Name = "comboBoxHomeTeam";
            this.comboBoxHomeTeam.Size = new System.Drawing.Size(121, 24);
            this.comboBoxHomeTeam.TabIndex = 0;
            this.comboBoxHomeTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxHomeTeam_SelectedIndexChanged);
            // 
            // comboBoxAwayTeam
            // 
            this.comboBoxAwayTeam.FormattingEnabled = true;
            this.comboBoxAwayTeam.Location = new System.Drawing.Point(579, 50);
            this.comboBoxAwayTeam.Name = "comboBoxAwayTeam";
            this.comboBoxAwayTeam.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAwayTeam.TabIndex = 1;
            this.comboBoxAwayTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxAwayTeam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "VS";
            // 
            // labelHomeManager
            // 
            this.labelHomeManager.AutoSize = true;
            this.labelHomeManager.Location = new System.Drawing.Point(43, 96);
            this.labelHomeManager.Name = "labelHomeManager";
            this.labelHomeManager.Size = new System.Drawing.Size(64, 17);
            this.labelHomeManager.TabIndex = 3;
            this.labelHomeManager.Text = "Manager";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // labelAwayManager
            // 
            this.labelAwayManager.AutoSize = true;
            this.labelAwayManager.Location = new System.Drawing.Point(576, 96);
            this.labelAwayManager.Name = "labelAwayManager";
            this.labelAwayManager.Size = new System.Drawing.Size(64, 17);
            this.labelAwayManager.TabIndex = 4;
            this.labelAwayManager.Text = "Manager";
            // 
            // labelHomeCaptain
            // 
            this.labelHomeCaptain.AutoSize = true;
            this.labelHomeCaptain.Location = new System.Drawing.Point(43, 122);
            this.labelHomeCaptain.Name = "labelHomeCaptain";
            this.labelHomeCaptain.Size = new System.Drawing.Size(56, 17);
            this.labelHomeCaptain.TabIndex = 5;
            this.labelHomeCaptain.Text = "Captain";
            // 
            // labelAwayCaptain
            // 
            this.labelAwayCaptain.AutoSize = true;
            this.labelAwayCaptain.Location = new System.Drawing.Point(576, 122);
            this.labelAwayCaptain.Name = "labelAwayCaptain";
            this.labelAwayCaptain.Size = new System.Drawing.Size(56, 17);
            this.labelAwayCaptain.TabIndex = 6;
            this.labelAwayCaptain.Text = "Captain";
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(286, 198);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(59, 17);
            this.labelStadium.TabIndex = 7;
            this.labelStadium.Text = "Stadium";
            // 
            // labelCapacity
            // 
            this.labelCapacity.Location = new System.Drawing.Point(0, 0);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(100, 23);
            this.labelCapacity.TabIndex = 0;
            // 
            // labelCapacity1
            // 
            this.labelCapacity1.AutoSize = true;
            this.labelCapacity1.Location = new System.Drawing.Point(286, 226);
            this.labelCapacity1.Name = "labelCapacity1";
            this.labelCapacity1.Size = new System.Drawing.Size(62, 17);
            this.labelCapacity1.TabIndex = 8;
            this.labelCapacity1.Text = "Capacity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCapacity1);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.labelStadium);
            this.Controls.Add(this.labelAwayCaptain);
            this.Controls.Add(this.labelHomeCaptain);
            this.Controls.Add(this.labelAwayManager);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelHomeManager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAwayTeam);
            this.Controls.Add(this.comboBoxHomeTeam);
            this.Name = "Form1";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxHomeTeam;
        private System.Windows.Forms.ComboBox comboBoxAwayTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHomeManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAwayManager;
        private System.Windows.Forms.Label labelHomeCaptain;
        private System.Windows.Forms.Label labelAwayCaptain;
        private System.Windows.Forms.Label labelStadium;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelCapacity1;
    }
}

