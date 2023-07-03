namespace Football_WindowsFormsApp
{
    partial class PlayerYellowCardUC
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
            pbImage1 = new PictureBox();
            lblImeiPrezime = new Label();
            lblBrojZutihKartona = new Label();
            pbImage2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbImage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImage2).BeginInit();
            SuspendLayout();
            // 
            // pbImage1
            // 
            pbImage1.Image = Properties.Resources.DefaultImageForPlayer;
            pbImage1.Location = new Point(3, 29);
            pbImage1.Name = "pbImage1";
            pbImage1.Size = new Size(63, 62);
            pbImage1.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage1.TabIndex = 0;
            pbImage1.TabStop = false;
            // 
            // lblImeiPrezime
            // 
            lblImeiPrezime.AutoSize = true;
            lblImeiPrezime.Location = new Point(84, 13);
            lblImeiPrezime.Name = "lblImeiPrezime";
            lblImeiPrezime.Size = new Size(78, 15);
            lblImeiPrezime.TabIndex = 1;
            lblImeiPrezime.Text = "Ime i prezime";
            // 
            // lblBrojZutihKartona
            // 
            lblBrojZutihKartona.AutoSize = true;
            lblBrojZutihKartona.Location = new Point(149, 76);
            lblBrojZutihKartona.Name = "lblBrojZutihKartona";
            lblBrojZutihKartona.Size = new Size(19, 15);
            lblBrojZutihKartona.TabIndex = 2;
            lblBrojZutihKartona.Text = "10";
            // 
            // pbImage2
            // 
            pbImage2.Image = Properties.Resources.YellowCard;
            pbImage2.Location = new Point(118, 54);
            pbImage2.Name = "pbImage2";
            pbImage2.Size = new Size(25, 37);
            pbImage2.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage2.TabIndex = 3;
            pbImage2.TabStop = false;
            // 
            // PlayerYellowCardUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pbImage2);
            Controls.Add(lblBrojZutihKartona);
            Controls.Add(lblImeiPrezime);
            Controls.Add(pbImage1);
            Name = "PlayerYellowCardUC";
            Size = new Size(210, 100);
            ((System.ComponentModel.ISupportInitialize)pbImage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImage2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage1;
        private Label lblImeiPrezime;
        private Label lblBrojZutihKartona;
        private PictureBox pbImage2;
    }
}
