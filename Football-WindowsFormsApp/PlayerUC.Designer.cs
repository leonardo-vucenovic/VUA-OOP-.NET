namespace Football_WindowsFormsApp
{
    partial class PlayerUC
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
            lblBrojDresa = new Label();
            lblImeIPrezime = new Label();
            lblKapetan = new Label();
            lblPozicija = new Label();
            pbSlikaIgraca = new PictureBox();
            pbNajdrazigrac = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbSlikaIgraca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNajdrazigrac).BeginInit();
            SuspendLayout();
            // 
            // lblBrojDresa
            // 
            lblBrojDresa.AutoSize = true;
            lblBrojDresa.Location = new Point(62, 15);
            lblBrojDresa.Name = "lblBrojDresa";
            lblBrojDresa.Size = new Size(59, 15);
            lblBrojDresa.TabIndex = 0;
            lblBrojDresa.Text = "Broj dresa";
            lblBrojDresa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblImeIPrezime
            // 
            lblImeIPrezime.AutoSize = true;
            lblImeIPrezime.Location = new Point(39, 133);
            lblImeIPrezime.Name = "lblImeIPrezime";
            lblImeIPrezime.Size = new Size(78, 15);
            lblImeIPrezime.TabIndex = 2;
            lblImeIPrezime.Text = "Ime i prezime";
            lblImeIPrezime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKapetan
            // 
            lblKapetan.AutoSize = true;
            lblKapetan.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblKapetan.ForeColor = Color.MediumSeaGreen;
            lblKapetan.Image = Properties.Resources.C;
            lblKapetan.Location = new Point(3, 3);
            lblKapetan.Name = "lblKapetan";
            lblKapetan.Size = new Size(26, 30);
            lblKapetan.TabIndex = 3;
            lblKapetan.Text = "C";
            // 
            // lblPozicija
            // 
            lblPozicija.AutoSize = true;
            lblPozicija.Location = new Point(39, 158);
            lblPozicija.Name = "lblPozicija";
            lblPozicija.Size = new Size(47, 15);
            lblPozicija.TabIndex = 4;
            lblPozicija.Text = "Pozicija";
            lblPozicija.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbSlikaIgraca
            // 
            pbSlikaIgraca.Image = Properties.Resources.DefaultImageForPlayer;
            pbSlikaIgraca.Location = new Point(39, 33);
            pbSlikaIgraca.Name = "pbSlikaIgraca";
            pbSlikaIgraca.Size = new Size(106, 97);
            pbSlikaIgraca.SizeMode = PictureBoxSizeMode.Zoom;
            pbSlikaIgraca.TabIndex = 5;
            pbSlikaIgraca.TabStop = false;
            pbSlikaIgraca.Click += pbSlikaIgraca_Click;
            // 
            // pbNajdrazigrac
            // 
            pbNajdrazigrac.Image = Properties.Resources.Star;
            pbNajdrazigrac.Location = new Point(150, 3);
            pbNajdrazigrac.Name = "pbNajdrazigrac";
            pbNajdrazigrac.Size = new Size(30, 30);
            pbNajdrazigrac.SizeMode = PictureBoxSizeMode.Zoom;
            pbNajdrazigrac.TabIndex = 6;
            pbNajdrazigrac.TabStop = false;
            pbNajdrazigrac.Visible = false;
            // 
            // PlayerUC
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pbNajdrazigrac);
            Controls.Add(pbSlikaIgraca);
            Controls.Add(lblPozicija);
            Controls.Add(lblKapetan);
            Controls.Add(lblImeIPrezime);
            Controls.Add(lblBrojDresa);
            Name = "PlayerUC";
            Size = new Size(183, 202);
            MouseDown += PlayerUC_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pbSlikaIgraca).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNajdrazigrac).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBrojDresa;
        private Label lblImeIPrezime;
        private Label lblKapetan;
        private Label lblPozicija;
        private PictureBox pbSlikaIgraca;
        private PictureBox pbNajdrazigrac;
    }
}
