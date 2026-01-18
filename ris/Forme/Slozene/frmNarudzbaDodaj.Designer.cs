namespace ris.Forme.Slozene
{
    partial class frmNarudzbaDodaj
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
            cboZaprimio = new ComboBox();
            label1 = new Label();
            dtpZaprimljena = new DateTimePicker();
            label2 = new Label();
            cboStatus = new ComboBox();
            label3 = new Label();
            cboStol = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txtSifra = new TextBox();
            dgvStavke = new DataGridView();
            label6 = new Label();
            btnSpremi = new Button();
            btnOdustani = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).BeginInit();
            SuspendLayout();
            // 
            // cboZaprimio
            // 
            cboZaprimio.FormattingEnabled = true;
            cboZaprimio.Location = new Point(551, 79);
            cboZaprimio.Name = "cboZaprimio";
            cboZaprimio.Size = new Size(237, 28);
            cboZaprimio.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 82);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Zaprimio";
            // 
            // dtpZaprimljena
            // 
            dtpZaprimljena.Location = new Point(551, 113);
            dtpZaprimljena.Name = "dtpZaprimljena";
            dtpZaprimljena.Size = new Size(237, 27);
            dtpZaprimljena.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(443, 118);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 3;
            label2.Text = "Zaprimljeno u";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(84, 79);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(128, 28);
            cboStatus.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 82);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Status";
            // 
            // cboStol
            // 
            cboStol.FormattingEnabled = true;
            cboStol.Location = new Point(84, 115);
            cboStol.Name = "cboStol";
            cboStol.Size = new Size(273, 28);
            cboStol.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 118);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 7;
            label4.Text = "Stol";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 46);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 9;
            label5.Text = "Šifra";
            // 
            // txtSifra
            // 
            txtSifra.Enabled = false;
            txtSifra.Location = new Point(84, 46);
            txtSifra.Name = "txtSifra";
            txtSifra.Size = new Size(125, 27);
            txtSifra.TabIndex = 10;
            // 
            // dgvStavke
            // 
            dgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStavke.Location = new Point(29, 178);
            dgvStavke.Name = "dgvStavke";
            dgvStavke.RowHeadersWidth = 51;
            dgvStavke.Size = new Size(759, 213);
            dgvStavke.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 155);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 12;
            label6.Text = "Stavke narudžbe";
            // 
            // btnSpremi
            // 
            btnSpremi.Location = new Point(517, 408);
            btnSpremi.Name = "btnSpremi";
            btnSpremi.Size = new Size(89, 30);
            btnSpremi.TabIndex = 13;
            btnSpremi.Text = "Spremi";
            btnSpremi.UseVisualStyleBackColor = true;
            btnSpremi.Click += btnSpremi_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(637, 408);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(89, 30);
            btnOdustani.TabIndex = 14;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // frmNarudzbaDodaj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOdustani);
            Controls.Add(btnSpremi);
            Controls.Add(label6);
            Controls.Add(dgvStavke);
            Controls.Add(txtSifra);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cboStol);
            Controls.Add(label3);
            Controls.Add(cboStatus);
            Controls.Add(label2);
            Controls.Add(dtpZaprimljena);
            Controls.Add(label1);
            Controls.Add(cboZaprimio);
            Name = "frmNarudzbaDodaj";
            Text = "frmNarudzbaDodaj";
            ((System.ComponentModel.ISupportInitialize)dgvStavke).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboZaprimio;
        private Label label1;
        private DateTimePicker dtpZaprimljena;
        private Label label2;
        private ComboBox cboStatus;
        private Label label3;
        private ComboBox cboStol;
        private Label label4;
        private Label label5;
        private TextBox txtSifra;
        private DataGridView dgvStavke;
        private Label label6;
        private Button btnSpremi;
        private Button btnOdustani;
    }
}