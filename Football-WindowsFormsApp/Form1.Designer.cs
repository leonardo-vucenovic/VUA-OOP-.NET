namespace Football_WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rbMuškiMale = new RadioButton();
            rbŽenskoFemale = new RadioButton();
            gbOdaberiteSpolChoseGender = new GroupBox();
            pbImage = new PictureBox();
            lblFIFA = new Label();
            gbOdaberitePodatkeChoceData = new GroupBox();
            rbFILE = new RadioButton();
            rbAPI = new RadioButton();
            btnNastaviContinue = new Button();
            gbOdaberiteSpolChoseGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            gbOdaberitePodatkeChoceData.SuspendLayout();
            SuspendLayout();
            // 
            // rbMuškiMale
            // 
            rbMuškiMale.AutoSize = true;
            rbMuškiMale.Checked = true;
            rbMuškiMale.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rbMuškiMale.ForeColor = Color.ForestGreen;
            rbMuškiMale.Location = new Point(6, 38);
            rbMuškiMale.Name = "rbMuškiMale";
            rbMuškiMale.Size = new Size(110, 23);
            rbMuškiMale.TabIndex = 0;
            rbMuškiMale.TabStop = true;
            rbMuškiMale.Text = "Muško-Male";
            rbMuškiMale.UseVisualStyleBackColor = true;
            // 
            // rbŽenskoFemale
            // 
            rbŽenskoFemale.AutoSize = true;
            rbŽenskoFemale.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rbŽenskoFemale.ForeColor = Color.ForestGreen;
            rbŽenskoFemale.Location = new Point(126, 63);
            rbŽenskoFemale.Name = "rbŽenskoFemale";
            rbŽenskoFemale.Size = new Size(129, 23);
            rbŽenskoFemale.TabIndex = 1;
            rbŽenskoFemale.Text = "Žensko-Female";
            rbŽenskoFemale.UseVisualStyleBackColor = true;
            // 
            // gbOdaberiteSpolChoseGender
            // 
            gbOdaberiteSpolChoseGender.BackColor = Color.White;
            gbOdaberiteSpolChoseGender.Controls.Add(rbŽenskoFemale);
            gbOdaberiteSpolChoseGender.Controls.Add(rbMuškiMale);
            gbOdaberiteSpolChoseGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbOdaberiteSpolChoseGender.ForeColor = Color.SeaGreen;
            gbOdaberiteSpolChoseGender.Location = new Point(413, 180);
            gbOdaberiteSpolChoseGender.Name = "gbOdaberiteSpolChoseGender";
            gbOdaberiteSpolChoseGender.Size = new Size(350, 115);
            gbOdaberiteSpolChoseGender.TabIndex = 2;
            gbOdaberiteSpolChoseGender.TabStop = false;
            gbOdaberiteSpolChoseGender.Text = "Odaberite spol/Chose gender";
            // 
            // pbImage
            // 
            pbImage.Image = Properties.Resources.FootballStart;
            pbImage.Location = new Point(12, 143);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(315, 346);
            pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
            pbImage.TabIndex = 3;
            pbImage.TabStop = false;
            // 
            // lblFIFA
            // 
            lblFIFA.AutoSize = true;
            lblFIFA.Font = new Font("Britannic Bold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblFIFA.ForeColor = Color.DarkGreen;
            lblFIFA.Location = new Point(173, 47);
            lblFIFA.Name = "lblFIFA";
            lblFIFA.Size = new Size(340, 44);
            lblFIFA.TabIndex = 4;
            lblFIFA.Text = "FIFA RUSSIA 2018";
            // 
            // gbOdaberitePodatkeChoceData
            // 
            gbOdaberitePodatkeChoceData.BackColor = Color.White;
            gbOdaberitePodatkeChoceData.Controls.Add(rbFILE);
            gbOdaberitePodatkeChoceData.Controls.Add(rbAPI);
            gbOdaberitePodatkeChoceData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbOdaberitePodatkeChoceData.ForeColor = Color.SeaGreen;
            gbOdaberitePodatkeChoceData.Location = new Point(451, 310);
            gbOdaberitePodatkeChoceData.Name = "gbOdaberitePodatkeChoceData";
            gbOdaberitePodatkeChoceData.Size = new Size(350, 108);
            gbOdaberitePodatkeChoceData.TabIndex = 6;
            gbOdaberitePodatkeChoceData.TabStop = false;
            gbOdaberitePodatkeChoceData.Text = "Odaberite nacin citanja podataka/Choose the way to read the data";
            // 
            // rbFILE
            // 
            rbFILE.AutoSize = true;
            rbFILE.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rbFILE.ForeColor = Color.ForestGreen;
            rbFILE.Location = new Point(260, 69);
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
            rbAPI.Location = new Point(191, 42);
            rbAPI.Name = "rbAPI";
            rbAPI.Size = new Size(50, 23);
            rbAPI.TabIndex = 0;
            rbAPI.TabStop = true;
            rbAPI.Text = "API";
            rbAPI.UseVisualStyleBackColor = true;
            // 
            // btnNastaviContinue
            // 
            btnNastaviContinue.Location = new Point(213, 605);
            btnNastaviContinue.Name = "btnNastaviContinue";
            btnNastaviContinue.Size = new Size(350, 44);
            btnNastaviContinue.TabIndex = 7;
            btnNastaviContinue.Text = "Nastavi/Continue";
            btnNastaviContinue.UseVisualStyleBackColor = true;
            btnNastaviContinue.Click += btnNastaviContinue_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(884, 661);
            Controls.Add(btnNastaviContinue);
            Controls.Add(gbOdaberitePodatkeChoceData);
            Controls.Add(lblFIFA);
            Controls.Add(pbImage);
            Controls.Add(gbOdaberiteSpolChoseGender);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nogomet/Football";
            Load += Form1_Load;
            gbOdaberiteSpolChoseGender.ResumeLayout(false);
            gbOdaberiteSpolChoseGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            gbOdaberitePodatkeChoceData.ResumeLayout(false);
            gbOdaberitePodatkeChoceData.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbMuškiMale;
        private RadioButton rbŽenskoFemale;
        private GroupBox gbOdaberiteSpolChoseGender;
        private PictureBox pbImage;
        private Label lblFIFA;
        private GroupBox gbOdaberitePodatkeChoceData;
        private RadioButton rbFILE;
        private RadioButton rbAPI;
        private Button btnNastaviContinue;
    }
}