namespace ris.Forme.Slozene
{
    partial class FrmNarudzbe
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
            dgvNarudzbe = new DataGridView();
            btnDodaj = new Button();
            btnObrisi = new Button();
            btnUredi = new Button();
            btnOsvjezi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNarudzbe).BeginInit();
            SuspendLayout();
            // 
            // dgvNarudzbe
            // 
            dgvNarudzbe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNarudzbe.Location = new Point(12, 12);
            dgvNarudzbe.Name = "dgvNarudzbe";
            dgvNarudzbe.RowHeadersWidth = 51;
            dgvNarudzbe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNarudzbe.Size = new Size(776, 391);
            dgvNarudzbe.TabIndex = 0;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(246, 409);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(139, 29);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj narudžbu";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(525, 409);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(135, 29);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obriši narudžbu";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnUredi
            // 
            btnUredi.Location = new Point(391, 409);
            btnUredi.Name = "btnUredi";
            btnUredi.Size = new Size(128, 29);
            btnUredi.TabIndex = 3;
            btnUredi.Text = "Uredi narudžbu";
            btnUredi.UseVisualStyleBackColor = true;
            btnUredi.Click += btnUredi_Click;
            // 
            // btnOsvjezi
            // 
            btnOsvjezi.Location = new Point(678, 409);
            btnOsvjezi.Name = "btnOsvjezi";
            btnOsvjezi.Size = new Size(110, 29);
            btnOsvjezi.TabIndex = 4;
            btnOsvjezi.Text = "Osvježi prikaz";
            btnOsvjezi.UseVisualStyleBackColor = true;
            btnOsvjezi.Click += btnOsvjezi_Click;
            // 
            // FrmNarudzbe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOsvjezi);
            Controls.Add(btnUredi);
            Controls.Add(btnObrisi);
            Controls.Add(btnDodaj);
            Controls.Add(dgvNarudzbe);
            Name = "FrmNarudzbe";
            Text = "FrmNarudzbe";
            ((System.ComponentModel.ISupportInitialize)dgvNarudzbe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvNarudzbe;
        private Button btnDodaj;
        private Button btnObrisi;
        private Button btnUredi;
        private Button btnOsvjezi;
    }
}