namespace Football_WindowsFormsApp
{
    partial class MatchUC
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
            lblNumberOfAttendance = new Label();
            lblHomeVsAway = new Label();
            lblImeStadiona = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNumberOfAttendance
            // 
            lblNumberOfAttendance.AutoSize = true;
            lblNumberOfAttendance.Location = new Point(129, 42);
            lblNumberOfAttendance.Name = "lblNumberOfAttendance";
            lblNumberOfAttendance.Size = new Size(28, 15);
            lblNumberOfAttendance.TabIndex = 0;
            lblNumberOfAttendance.Text = "Broj";
            // 
            // lblHomeVsAway
            // 
            lblHomeVsAway.AutoSize = true;
            lblHomeVsAway.Location = new Point(50, 73);
            lblHomeVsAway.Name = "lblHomeVsAway";
            lblHomeVsAway.Size = new Size(88, 15);
            lblHomeVsAway.TabIndex = 1;
            lblHomeVsAway.Text = "Home VS Away";
            // 
            // lblImeStadiona
            // 
            lblImeStadiona.AutoSize = true;
            lblImeStadiona.Location = new Point(50, 8);
            lblImeStadiona.Name = "lblImeStadiona";
            lblImeStadiona.Size = new Size(75, 15);
            lblImeStadiona.TabIndex = 2;
            lblImeStadiona.Text = "Ime stadiona";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CampNou;
            pictureBox1.Location = new Point(13, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // MatchUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pictureBox1);
            Controls.Add(lblImeStadiona);
            Controls.Add(lblHomeVsAway);
            Controls.Add(lblNumberOfAttendance);
            Name = "MatchUC";
            Size = new Size(210, 100);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumberOfAttendance;
        private Label lblHomeVsAway;
        private Label lblImeStadiona;
        private PictureBox pictureBox1;
    }
}
