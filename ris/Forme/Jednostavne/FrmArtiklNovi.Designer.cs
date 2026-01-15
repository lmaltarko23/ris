namespace ris.Forme.Jednostavne
{
    partial class FrmArtiklNovi
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
            txtNaziv = new TextBox();
            cboKategorija = new ComboBox();
            txtOpis = new RichTextBox();
            txtCijena = new TextBox();
            ckbDostupan = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(286, 53);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(229, 27);
            txtNaziv.TabIndex = 0;
            // 
            // cboKategorija
            // 
            cboKategorija.FormattingEnabled = true;
            cboKategorija.Location = new Point(286, 86);
            cboKategorija.Name = "cboKategorija";
            cboKategorija.Size = new Size(229, 28);
            cboKategorija.TabIndex = 1;
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(78, 160);
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(437, 135);
            txtOpis.TabIndex = 2;
            txtOpis.Text = "";
            // 
            // txtCijena
            // 
            txtCijena.Location = new Point(410, 120);
            txtCijena.Name = "txtCijena";
            txtCijena.Size = new Size(78, 27);
            txtCijena.TabIndex = 3;
            // 
            // ckbDostupan
            // 
            ckbDostupan.AutoSize = true;
            ckbDostupan.Location = new Point(234, 124);
            ckbDostupan.Name = "ckbDostupan";
            ckbDostupan.Size = new Size(95, 24);
            ckbDostupan.TabIndex = 4;
            ckbDostupan.Text = "Dostupan";
            ckbDostupan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 60);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 5;
            label1.Text = "Naziv";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 89);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 6;
            label2.Text = "Kategorija";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 126);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "Cijena";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 137);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 8;
            label4.Text = "Opis";
            // 
            // button1
            // 
            button1.Location = new Point(421, 338);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Spremi";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmArtiklNovi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 407);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ckbDostupan);
            Controls.Add(txtCijena);
            Controls.Add(txtOpis);
            Controls.Add(cboKategorija);
            Controls.Add(txtNaziv);
            Name = "FrmArtiklNovi";
            Text = "FrmArtiklNovi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNaziv;
        private ComboBox cboKategorija;
        private RichTextBox txtOpis;
        private TextBox txtCijena;
        private CheckBox ckbDostupan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}