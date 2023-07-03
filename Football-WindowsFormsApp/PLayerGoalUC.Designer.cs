namespace Football_WindowsFormsApp
{
    partial class PLayerGoalUC
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
            lblImeiPrezime = new Label();
            lblBrojGolova = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblImeiPrezime
            // 
            lblImeiPrezime.AutoSize = true;
            lblImeiPrezime.Location = new Point(60, 13);
            lblImeiPrezime.Name = "lblImeiPrezime";
            lblImeiPrezime.Size = new Size(78, 15);
            lblImeiPrezime.TabIndex = 0;
            lblImeiPrezime.Text = "Ime i prezime";
            // 
            // lblBrojGolova
            // 
            lblBrojGolova.AutoSize = true;
            lblBrojGolova.Location = new Point(144, 82);
            lblBrojGolova.Name = "lblBrojGolova";
            lblBrojGolova.Size = new Size(19, 15);
            lblBrojGolova.TabIndex = 1;
            lblBrojGolova.Text = "10";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.DefaultImageForPlayer;
            pictureBox1.Location = new Point(3, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Goal;
            pictureBox2.Location = new Point(97, 73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // PLayerGoalUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblBrojGolova);
            Controls.Add(lblImeiPrezime);
            Name = "PLayerGoalUC";
            Size = new Size(210, 100);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblImeiPrezime;
        private Label lblBrojGolova;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
