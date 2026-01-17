namespace ris.Forme.Jednostavne
{
    partial class frmKategorijaDodaj
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
            btnSpremi = new Button();
            btnOdustani = new Button();
            txtNaziv = new TextBox();
            txtOpis = new RichTextBox();
            lblNaziv = new Label();
            lblOpis = new Label();
            SuspendLayout();
            // 
            // btnSpremi
            // 
            btnSpremi.Location = new Point(406, 281);
            btnSpremi.Name = "btnSpremi";
            btnSpremi.Size = new Size(94, 29);
            btnSpremi.TabIndex = 0;
            btnSpremi.Text = "Spremi";
            btnSpremi.UseVisualStyleBackColor = true;
            btnSpremi.Click += btnSpremi_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(140, 281);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(94, 29);
            btnOdustani.TabIndex = 1;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(124, 50);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(125, 27);
            txtNaziv.TabIndex = 2;
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(121, 111);
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(398, 120);
            txtOpis.TabIndex = 3;
            txtOpis.Text = "";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(63, 53);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(46, 20);
            lblNaziv.TabIndex = 4;
            lblNaziv.Text = "Naziv";
            // 
            // lblOpis
            // 
            lblOpis.AutoSize = true;
            lblOpis.Location = new Point(70, 114);
            lblOpis.Name = "lblOpis";
            lblOpis.Size = new Size(39, 20);
            lblOpis.TabIndex = 5;
            lblOpis.Text = "Opis";
            // 
            // frmKategorijaDodaj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 366);
            Controls.Add(lblOpis);
            Controls.Add(lblNaziv);
            Controls.Add(txtOpis);
            Controls.Add(txtNaziv);
            Controls.Add(btnOdustani);
            Controls.Add(btnSpremi);
            Name = "frmKategorijaDodaj";
            Text = "frmKategorijaCU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSpremi;
        private Button btnOdustani;
        private TextBox txtNaziv;
        private RichTextBox txtOpis;
        private Label lblNaziv;
        private Label lblOpis;
    }
}