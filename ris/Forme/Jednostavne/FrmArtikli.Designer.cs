namespace ris.Forme.Jednostavne
{
    partial class FrmArtikli
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
            dgvArtikli = new DataGridView();
            btnNovi = new Button();
            btnUredi = new Button();
            btnOsvjezi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArtikli).BeginInit();
            SuspendLayout();
            // 
            // dgvArtikli
            // 
            dgvArtikli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtikli.Location = new Point(15, 16);
            dgvArtikli.Name = "dgvArtikli";
            dgvArtikli.RowHeadersWidth = 51;
            dgvArtikli.Size = new Size(773, 389);
            dgvArtikli.TabIndex = 0;
            // 
            // btnNovi
            // 
            btnNovi.Location = new Point(652, 411);
            btnNovi.Name = "btnNovi";
            btnNovi.Size = new Size(136, 27);
            btnNovi.TabIndex = 1;
            btnNovi.Text = "Dodaj novi artikl";
            btnNovi.UseVisualStyleBackColor = true;
            // 
            // btnUredi
            // 
            btnUredi.Location = new Point(546, 411);
            btnUredi.Name = "btnUredi";
            btnUredi.Size = new Size(100, 27);
            btnUredi.TabIndex = 2;
            btnUredi.Text = "Uredi artikl";
            btnUredi.UseVisualStyleBackColor = true;
            // 
            // btnOsvjezi
            // 
            btnOsvjezi.Location = new Point(464, 411);
            btnOsvjezi.Name = "btnOsvjezi";
            btnOsvjezi.Size = new Size(76, 27);
            btnOsvjezi.TabIndex = 3;
            btnOsvjezi.Text = "Osvježi";
            btnOsvjezi.UseVisualStyleBackColor = true;
            btnOsvjezi.Click += btnOsvjezi_Click;
            // 
            // FrmArtikli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOsvjezi);
            Controls.Add(btnUredi);
            Controls.Add(btnNovi);
            Controls.Add(dgvArtikli);
            Name = "FrmArtikli";
            Text = "FrmArtikli";
            ((System.ComponentModel.ISupportInitialize)dgvArtikli).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvArtikli;
        private Button btnNovi;
        private Button btnUredi;
        private Button btnOsvjezi;
    }
}