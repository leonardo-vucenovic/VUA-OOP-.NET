namespace Football_WindowsFormsApp
{
    partial class RangLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RangLists));
            btnNatrag = new Button();
            btnPrintYellowCard = new Button();
            lblImeDrzave = new Label();
            flpYellowCard = new FlowLayoutPanel();
            flyGoal = new FlowLayoutPanel();
            flyVisitors = new FlowLayoutPanel();
            btnPrintGoals = new Button();
            btnPrintVisitors = new Button();
            label1 = new Label();
            pbLoading = new PictureBox();
            lblLoading = new Label();
            printDialog = new PrintDialog();
            printDocument = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)pbLoading).BeginInit();
            SuspendLayout();
            // 
            // btnNatrag
            // 
            btnNatrag.BackColor = Color.MediumSeaGreen;
            btnNatrag.Location = new Point(719, 12);
            btnNatrag.Name = "btnNatrag";
            btnNatrag.Size = new Size(153, 45);
            btnNatrag.TabIndex = 0;
            btnNatrag.Text = "Natrag";
            btnNatrag.UseVisualStyleBackColor = false;
            btnNatrag.Click += btnNatrag_Click;
            // 
            // btnPrintYellowCard
            // 
            btnPrintYellowCard.Location = new Point(61, 594);
            btnPrintYellowCard.Name = "btnPrintYellowCard";
            btnPrintYellowCard.Size = new Size(247, 31);
            btnPrintYellowCard.TabIndex = 1;
            btnPrintYellowCard.Text = "Ispis";
            btnPrintYellowCard.UseVisualStyleBackColor = true;
            btnPrintYellowCard.Click += btnPrintYellowCard_Click;
            // 
            // lblImeDrzave
            // 
            lblImeDrzave.AutoSize = true;
            lblImeDrzave.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblImeDrzave.ForeColor = Color.MediumSeaGreen;
            lblImeDrzave.Location = new Point(381, 44);
            lblImeDrzave.Name = "lblImeDrzave";
            lblImeDrzave.Size = new Size(142, 54);
            lblImeDrzave.TabIndex = 5;
            lblImeDrzave.Text = "Drzava";
            // 
            // flpYellowCard
            // 
            flpYellowCard.AutoScroll = true;
            flpYellowCard.BorderStyle = BorderStyle.FixedSingle;
            flpYellowCard.Location = new Point(61, 127);
            flpYellowCard.Name = "flpYellowCard";
            flpYellowCard.Size = new Size(247, 457);
            flpYellowCard.TabIndex = 6;
            // 
            // flyGoal
            // 
            flyGoal.AutoScroll = true;
            flyGoal.BorderStyle = BorderStyle.FixedSingle;
            flyGoal.Location = new Point(319, 127);
            flyGoal.Name = "flyGoal";
            flyGoal.Size = new Size(247, 457);
            flyGoal.TabIndex = 7;
            // 
            // flyVisitors
            // 
            flyVisitors.AutoScroll = true;
            flyVisitors.BorderStyle = BorderStyle.FixedSingle;
            flyVisitors.Location = new Point(572, 127);
            flyVisitors.Name = "flyVisitors";
            flyVisitors.Size = new Size(247, 457);
            flyVisitors.TabIndex = 8;
            // 
            // btnPrintGoals
            // 
            btnPrintGoals.Location = new Point(319, 594);
            btnPrintGoals.Name = "btnPrintGoals";
            btnPrintGoals.Size = new Size(247, 31);
            btnPrintGoals.TabIndex = 9;
            btnPrintGoals.Text = "Ispis";
            btnPrintGoals.UseVisualStyleBackColor = true;
            btnPrintGoals.Click += btnPrintYellowCard_Click;
            // 
            // btnPrintVisitors
            // 
            btnPrintVisitors.Location = new Point(572, 594);
            btnPrintVisitors.Name = "btnPrintVisitors";
            btnPrintVisitors.Size = new Size(247, 31);
            btnPrintVisitors.TabIndex = 10;
            btnPrintVisitors.Text = "Ispis";
            btnPrintVisitors.UseVisualStyleBackColor = true;
            btnPrintVisitors.Click += btnPrintYellowCard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(61, 52);
            label1.Name = "label1";
            label1.Size = new Size(291, 46);
            label1.TabIndex = 11;
            label1.Text = "Odabrana država";
            // 
            // pbLoading
            // 
            pbLoading.Image = Properties.Resources.Loading;
            pbLoading.ImeMode = ImeMode.NoControl;
            pbLoading.Location = new Point(139, 9);
            pbLoading.Name = "pbLoading";
            pbLoading.Size = new Size(27, 31);
            pbLoading.SizeMode = PictureBoxSizeMode.Zoom;
            pbLoading.TabIndex = 20;
            pbLoading.TabStop = false;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoading.ImeMode = ImeMode.NoControl;
            lblLoading.Location = new Point(12, 9);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(131, 31);
            lblLoading.TabIndex = 19;
            lblLoading.Text = "Učitavanje..";
            // 
            // printDialog
            // 
            printDialog.Document = printDocument;
            printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            printDocument.EndPrint += PrintDocument_EndPrint;
            printDocument.PrintPage += PrintDocument_PrintPage;
            // 
            // printPreviewDialog
            // 
            printPreviewDialog.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Enabled = true;
            printPreviewDialog.Icon = (Icon)resources.GetObject("printPreviewDialog.Icon");
            printPreviewDialog.Name = "printPreviewDialog1";
            printPreviewDialog.Visible = false;
            // 
            // RangLists
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(884, 661);
            Controls.Add(pbLoading);
            Controls.Add(lblLoading);
            Controls.Add(label1);
            Controls.Add(btnPrintVisitors);
            Controls.Add(btnPrintGoals);
            Controls.Add(flpYellowCard);
            Controls.Add(flyVisitors);
            Controls.Add(flyGoal);
            Controls.Add(lblImeDrzave);
            Controls.Add(btnPrintYellowCard);
            Controls.Add(btnNatrag);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RangLists";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rang liste";
            Load += RangLists_Load;
            ((System.ComponentModel.ISupportInitialize)pbLoading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNatrag;
        private Button btnPrintYellowCard;
        private Label lblImeDrzave;
        private FlowLayoutPanel flpYellowCard;
        private FlowLayoutPanel flyGoal;
        private FlowLayoutPanel flyVisitors;
        private Button btnPrintGoals;
        private Button btnPrintVisitors;
        private Label label1;
        private PictureBox pbLoading;
        private Label lblLoading;
        private PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
    }
}