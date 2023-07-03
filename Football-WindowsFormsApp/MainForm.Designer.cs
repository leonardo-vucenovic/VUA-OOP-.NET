namespace Football_WindowsFormsApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnPostavke = new Button();
            lblOdaberiOmiljeniTim = new Label();
            cbOmiljeniTim = new ComboBox();
            btnPrikazeIgraceZaOdabranuDrzavu = new Button();
            flpSviIgraci = new FlowLayoutPanel();
            flpOmiljeniIgraci = new FlowLayoutPanel();
            btnPrikaziStatistikuZaOdabranuDrzavu = new Button();
            lblSviIgraci = new Label();
            lblNajdraziIgraci = new Label();
            pictureBox1 = new PictureBox();
            lblLoading = new Label();
            pbLoading = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLoading).BeginInit();
            SuspendLayout();
            // 
            // btnPostavke
            // 
            btnPostavke.BackColor = Color.MediumSeaGreen;
            resources.ApplyResources(btnPostavke, "btnPostavke");
            btnPostavke.Name = "btnPostavke";
            btnPostavke.UseVisualStyleBackColor = false;
            btnPostavke.Click += btnPostavke_Click;
            // 
            // lblOdaberiOmiljeniTim
            // 
            resources.ApplyResources(lblOdaberiOmiljeniTim, "lblOdaberiOmiljeniTim");
            lblOdaberiOmiljeniTim.BackColor = Color.MediumSeaGreen;
            lblOdaberiOmiljeniTim.Name = "lblOdaberiOmiljeniTim";
            // 
            // cbOmiljeniTim
            // 
            cbOmiljeniTim.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOmiljeniTim.FormattingEnabled = true;
            resources.ApplyResources(cbOmiljeniTim, "cbOmiljeniTim");
            cbOmiljeniTim.Name = "cbOmiljeniTim";
            // 
            // btnPrikazeIgraceZaOdabranuDrzavu
            // 
            btnPrikazeIgraceZaOdabranuDrzavu.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnPrikazeIgraceZaOdabranuDrzavu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPrikazeIgraceZaOdabranuDrzavu.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            resources.ApplyResources(btnPrikazeIgraceZaOdabranuDrzavu, "btnPrikazeIgraceZaOdabranuDrzavu");
            btnPrikazeIgraceZaOdabranuDrzavu.Name = "btnPrikazeIgraceZaOdabranuDrzavu";
            btnPrikazeIgraceZaOdabranuDrzavu.UseVisualStyleBackColor = true;
            btnPrikazeIgraceZaOdabranuDrzavu.Click += btnPrikazeIgraceZaOdabranuDrzavu_Click;
            // 
            // flpSviIgraci
            // 
            flpSviIgraci.AllowDrop = true;
            resources.ApplyResources(flpSviIgraci, "flpSviIgraci");
            flpSviIgraci.BorderStyle = BorderStyle.FixedSingle;
            flpSviIgraci.Name = "flpSviIgraci";
            flpSviIgraci.DragDrop += flpSviIgraci_DragDrop;
            flpSviIgraci.DragOver += flpSviIgraci_DragOver;
            // 
            // flpOmiljeniIgraci
            // 
            flpOmiljeniIgraci.AllowDrop = true;
            resources.ApplyResources(flpOmiljeniIgraci, "flpOmiljeniIgraci");
            flpOmiljeniIgraci.BorderStyle = BorderStyle.FixedSingle;
            flpOmiljeniIgraci.Name = "flpOmiljeniIgraci";
            flpOmiljeniIgraci.DragDrop += flpOmiljeniIgraci_DragDrop;
            flpOmiljeniIgraci.DragOver += flpOmiljeniIgraci_DragOver;
            // 
            // btnPrikaziStatistikuZaOdabranuDrzavu
            // 
            btnPrikaziStatistikuZaOdabranuDrzavu.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnPrikaziStatistikuZaOdabranuDrzavu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPrikaziStatistikuZaOdabranuDrzavu.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            resources.ApplyResources(btnPrikaziStatistikuZaOdabranuDrzavu, "btnPrikaziStatistikuZaOdabranuDrzavu");
            btnPrikaziStatistikuZaOdabranuDrzavu.Name = "btnPrikaziStatistikuZaOdabranuDrzavu";
            btnPrikaziStatistikuZaOdabranuDrzavu.UseVisualStyleBackColor = true;
            btnPrikaziStatistikuZaOdabranuDrzavu.Click += btnPrikaziStatistikuZaOdabranuDrzavu_Click;
            // 
            // lblSviIgraci
            // 
            resources.ApplyResources(lblSviIgraci, "lblSviIgraci");
            lblSviIgraci.Name = "lblSviIgraci";
            // 
            // lblNajdraziIgraci
            // 
            resources.ApplyResources(lblNajdraziIgraci, "lblNajdraziIgraci");
            lblNajdraziIgraci.Name = "lblNajdraziIgraci";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MainFormImge;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // lblLoading
            // 
            resources.ApplyResources(lblLoading, "lblLoading");
            lblLoading.Name = "lblLoading";
            // 
            // pbLoading
            // 
            pbLoading.Image = Properties.Resources.Loading;
            resources.ApplyResources(pbLoading, "pbLoading");
            pbLoading.Name = "pbLoading";
            pbLoading.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            Controls.Add(pbLoading);
            Controls.Add(lblLoading);
            Controls.Add(pictureBox1);
            Controls.Add(lblNajdraziIgraci);
            Controls.Add(lblSviIgraci);
            Controls.Add(btnPrikaziStatistikuZaOdabranuDrzavu);
            Controls.Add(flpOmiljeniIgraci);
            Controls.Add(flpSviIgraci);
            Controls.Add(btnPrikazeIgraceZaOdabranuDrzavu);
            Controls.Add(cbOmiljeniTim);
            Controls.Add(lblOdaberiOmiljeniTim);
            Controls.Add(btnPostavke);
            Name = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLoading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPostavke;
        private Label lblOdaberiOmiljeniTim;
        private ComboBox cbOmiljeniTim;
        private Button btnPrikazeIgraceZaOdabranuDrzavu;
        private FlowLayoutPanel flpSviIgraci;
        private FlowLayoutPanel flpOmiljeniIgraci;
        private Button btnPrikaziStatistikuZaOdabranuDrzavu;
        private Label lblSviIgraci;
        private Label lblNajdraziIgraci;
        private PictureBox pictureBox1;
        private Label lblLoading;
        private PictureBox pbLoading;
    }
}