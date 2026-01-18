namespace ris.Forme.Jednostavne
{
    partial class frmKategorija
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
            dgvKategorija = new DataGridView();
            btnDodaj = new Button();
            btnOsvjezi = new Button();
            btnUredi = new Button();
            btnObrisi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKategorija).BeginInit();
            SuspendLayout();
            // 
            // dgvKategorija
            // 
            dgvKategorija.AllowUserToAddRows = false;
            dgvKategorija.AllowUserToDeleteRows = false;
            dgvKategorija.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKategorija.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategorija.Location = new Point(14, 12);
            dgvKategorija.MultiSelect = false;
            dgvKategorija.Name = "dgvKategorija";
            dgvKategorija.ReadOnly = true;
            dgvKategorija.RowHeadersWidth = 51;
            dgvKategorija.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKategorija.Size = new Size(773, 344);
            dgvKategorija.TabIndex = 0;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(208, 381);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(170, 29);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj novu kategoriju";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodajNovu_Click;
            // 
            // btnOsvjezi
            // 
            btnOsvjezi.Location = new Point(681, 381);
            btnOsvjezi.Name = "btnOsvjezi";
            btnOsvjezi.Size = new Size(106, 29);
            btnOsvjezi.TabIndex = 2;
            btnOsvjezi.Text = "Osvježi listu";
            btnOsvjezi.UseVisualStyleBackColor = true;
            btnOsvjezi.Click += button1_Click;
            // 
            // btnUredi
            // 
            btnUredi.Location = new Point(384, 381);
            btnUredi.Name = "btnUredi";
            btnUredi.Size = new Size(137, 29);
            btnUredi.TabIndex = 3;
            btnUredi.Text = "Uredi kategoriju";
            btnUredi.UseVisualStyleBackColor = true;
            btnUredi.Click += btnUredi_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(527, 381);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(134, 29);
            btnObrisi.TabIndex = 4;
            btnObrisi.Text = "Obriši kategoriju";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // frmKategorija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnObrisi);
            Controls.Add(btnUredi);
            Controls.Add(btnOsvjezi);
            Controls.Add(btnDodaj);
            Controls.Add(dgvKategorija);
            Name = "frmKategorija";
            Text = "Pregled kategorija";
            Load += frmKategorija_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKategorija).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKategorija;
        private Button btnDodajNovu;
        private Button btnOsvjezi;
        private Button button1;
        private Button button2;
        private Button btnDodaj;
        private Button btnUredi;
        private Button btnObrisi;
    }
}