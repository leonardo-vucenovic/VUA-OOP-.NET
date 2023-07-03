namespace Football_WindowsFormsApp
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            gbOdaberitePodatkeChoceData = new GroupBox();
            rbFILE = new RadioButton();
            rbAPI = new RadioButton();
            gbOdaberiteSpolChoseGender = new GroupBox();
            rbŽenskoFemale = new RadioButton();
            rbMuškiMale = new RadioButton();
            btnSpremiPromjene = new Button();
            lblPostavke = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            lblTrenutnePostavke = new Label();
            gbOdaberitePodatkeChoceData.SuspendLayout();
            gbOdaberiteSpolChoseGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // gbOdaberitePodatkeChoceData
            // 
            gbOdaberitePodatkeChoceData.BackColor = Color.White;
            gbOdaberitePodatkeChoceData.Controls.Add(rbFILE);
            gbOdaberitePodatkeChoceData.Controls.Add(rbAPI);
            gbOdaberitePodatkeChoceData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbOdaberitePodatkeChoceData.ForeColor = Color.SeaGreen;
            gbOdaberitePodatkeChoceData.Location = new Point(494, 307);
            gbOdaberitePodatkeChoceData.Name = "gbOdaberitePodatkeChoceData";
            gbOdaberitePodatkeChoceData.Size = new Size(352, 112);
            gbOdaberitePodatkeChoceData.TabIndex = 9;
            gbOdaberitePodatkeChoceData.TabStop = false;
            gbOdaberitePodatkeChoceData.Text = "Odaberite podatke/Chose data";
            // 
            // rbFILE
            // 
            rbFILE.AutoSize = true;
            rbFILE.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rbFILE.ForeColor = Color.ForestGreen;
            rbFILE.Location = new Point(72, 75);
            rbFILE.Name = "rbFILE";
            rbFILE.Size = new Size(52, 23);
            rbFILE.TabIndex = 1;
            rbFILE.Text = "FILE";
            rbFILE.UseVisualStyleBackColor = true;
            // 
            // rbAPI
            // 
            rbAPI.AutoSize = true;
            rbAPI.Checked = true;
            rbAPI.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rbAPI.ForeColor = Color.ForestGreen;
            rbAPI.Location = new Point(72, 37);
            rbAPI.Name = "rbAPI";
            rbAPI.Size = new Size(50, 23);
            rbAPI.TabIndex = 0;
            rbAPI.TabStop = true;
            rbAPI.Text = "API";
            rbAPI.UseVisualStyleBackColor = true;
            // 
            // gbOdaberiteSpolChoseGender
            // 
            gbOdaberiteSpolChoseGender.BackColor = Color.White;
            gbOdaberiteSpolChoseGender.Controls.Add(rbŽenskoFemale);
            gbOdaberiteSpolChoseGender.Controls.Add(rbMuškiMale);
            gbOdaberiteSpolChoseGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbOdaberiteSpolChoseGender.ForeColor = Color.SeaGreen;
            gbOdaberiteSpolChoseGender.Location = new Point(494, 128);
            gbOdaberiteSpolChoseGender.Name = "gbOdaberiteSpolChoseGender";
            gbOdaberiteSpolChoseGender.Size = new Size(352, 112);
            gbOdaberiteSpolChoseGender.TabIndex = 7;
            gbOdaberiteSpolChoseGender.TabStop = false;
            gbOdaberiteSpolChoseGender.Text = "Odaberite spol/Chose gender";
            // 
            // rbŽenskoFemale
            // 
            rbŽenskoFemale.AutoSize = true;
            rbŽenskoFemale.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rbŽenskoFemale.ForeColor = Color.ForestGreen;
            rbŽenskoFemale.Location = new Point(72, 76);
            rbŽenskoFemale.Name = "rbŽenskoFemale";
            rbŽenskoFemale.Size = new Size(129, 23);
            rbŽenskoFemale.TabIndex = 1;
            rbŽenskoFemale.Text = "Žensko-Female";
            rbŽenskoFemale.UseVisualStyleBackColor = true;
            // 
            // rbMuškiMale
            // 
            rbMuškiMale.AutoSize = true;
            rbMuškiMale.Checked = true;
            rbMuškiMale.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rbMuškiMale.ForeColor = Color.ForestGreen;
            rbMuškiMale.Location = new Point(72, 38);
            rbMuškiMale.Name = "rbMuškiMale";
            rbMuškiMale.Size = new Size(110, 23);
            rbMuškiMale.TabIndex = 0;
            rbMuškiMale.TabStop = true;
            rbMuškiMale.Text = "Muško-Male";
            rbMuškiMale.UseVisualStyleBackColor = true;
            // 
            // btnSpremiPromjene
            // 
            btnSpremiPromjene.BackColor = Color.MediumSeaGreen;
            btnSpremiPromjene.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSpremiPromjene.Location = new Point(730, 587);
            btnSpremiPromjene.Name = "btnSpremiPromjene";
            btnSpremiPromjene.Size = new Size(128, 52);
            btnSpremiPromjene.TabIndex = 10;
            btnSpremiPromjene.Text = "Spremi promjene";
            btnSpremiPromjene.UseVisualStyleBackColor = false;
            btnSpremiPromjene.Click += btnSpremiPromjene_Click;
            // 
            // lblPostavke
            // 
            lblPostavke.AutoSize = true;
            lblPostavke.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPostavke.Location = new Point(219, 84);
            lblPostavke.Name = "lblPostavke";
            lblPostavke.Size = new Size(133, 37);
            lblPostavke.TabIndex = 11;
            lblPostavke.Text = "Postavke";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FootballField;
            pictureBox1.Location = new Point(22, 451);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Settings;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 109);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 215);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 14;
            label1.Text = "Muško-Male";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 240);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 16;
            label3.Text = "API";
            // 
            // lblTrenutnePostavke
            // 
            lblTrenutnePostavke.AutoSize = true;
            lblTrenutnePostavke.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTrenutnePostavke.Location = new Point(22, 187);
            lblTrenutnePostavke.Name = "lblTrenutnePostavke";
            lblTrenutnePostavke.Size = new Size(155, 21);
            lblTrenutnePostavke.TabIndex = 17;
            lblTrenutnePostavke.Text = "Trenutne postavke:";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(884, 661);
            Controls.Add(lblTrenutnePostavke);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(gbOdaberitePodatkeChoceData);
            Controls.Add(lblPostavke);
            Controls.Add(btnSpremiPromjene);
            Controls.Add(gbOdaberiteSpolChoseGender);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Postavke";
            Load += SettingsForm_Load;
            gbOdaberitePodatkeChoceData.ResumeLayout(false);
            gbOdaberitePodatkeChoceData.PerformLayout();
            gbOdaberiteSpolChoseGender.ResumeLayout(false);
            gbOdaberiteSpolChoseGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbOdaberitePodatkeChoceData;
        private RadioButton rbFILE;
        private RadioButton rbAPI;
        private GroupBox gbOdaberiteSpolChoseGender;
        private RadioButton rbŽenskoFemale;
        private RadioButton rbMuškiMale;
        private Button btnSpremiPromjene;
        private Label lblPostavke;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label3;
        private Label lblTrenutnePostavke;
    }
}