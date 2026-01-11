namespace ris
{
    partial class FrmPrijava
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblKorime = new Label();
            lblLozinka = new Label();
            txtKorime = new TextBox();
            txtLozinka = new TextBox();
            btnPrijava = new Button();
            SuspendLayout();
            // 
            // lblKorime
            // 
            lblKorime.AutoSize = true;
            lblKorime.Location = new Point(254, 158);
            lblKorime.Name = "lblKorime";
            lblKorime.Size = new Size(106, 20);
            lblKorime.TabIndex = 0;
            lblKorime.Text = "Korisničko ime";
            // 
            // lblLozinka
            // 
            lblLozinka.AutoSize = true;
            lblLozinka.Location = new Point(254, 191);
            lblLozinka.Name = "lblLozinka";
            lblLozinka.Size = new Size(59, 20);
            lblLozinka.TabIndex = 1;
            lblLozinka.Text = "Lozinka";
            lblLozinka.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtKorime
            // 
            txtKorime.Location = new Point(393, 155);
            txtKorime.Name = "txtKorime";
            txtKorime.Size = new Size(172, 27);
            txtKorime.TabIndex = 2;
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(393, 191);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(172, 27);
            txtLozinka.TabIndex = 3;
            // 
            // btnPrijava
            // 
            btnPrijava.Location = new Point(471, 271);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(94, 29);
            btnPrijava.TabIndex = 4;
            btnPrijava.Text = "Prijava";
            btnPrijava.UseVisualStyleBackColor = true;
            btnPrijava.Click += btnPrijava_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrijava);
            Controls.Add(txtLozinka);
            Controls.Add(txtKorime);
            Controls.Add(lblLozinka);
            Controls.Add(lblKorime);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKorime;
        private Label lblLozinka;
        private TextBox txtKorime;
        private TextBox txtLozinka;
        private Button btnPrijava;
    }
}
