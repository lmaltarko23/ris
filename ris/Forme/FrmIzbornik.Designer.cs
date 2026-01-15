namespace ris.Forme
{
    partial class FrmIzbornik
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
            btnPregledDjelatnika = new Button();
            btnPregledStolova = new Button();
            btnPregledNarudzbi = new Button();
            btnNovaNarudzba = new Button();
            btnNaplata = new Button();
            btnNovaRezervacija = new Button();
            btnPregledRezervacija = new Button();
            SuspendLayout();
            // 
            // btnPregledDjelatnika
            // 
            btnPregledDjelatnika.Location = new Point(608, 305);
            btnPregledDjelatnika.Name = "btnPregledDjelatnika";
            btnPregledDjelatnika.Size = new Size(162, 112);
            btnPregledDjelatnika.TabIndex = 0;
            btnPregledDjelatnika.Text = "Pregled djelatnika";
            btnPregledDjelatnika.UseVisualStyleBackColor = true;
            btnPregledDjelatnika.Click += btnPregledDjelatnika_Click;
            // 
            // btnPregledStolova
            // 
            btnPregledStolova.Location = new Point(608, 166);
            btnPregledStolova.Name = "btnPregledStolova";
            btnPregledStolova.Size = new Size(162, 112);
            btnPregledStolova.TabIndex = 1;
            btnPregledStolova.Text = "Pregled stolova";
            btnPregledStolova.UseVisualStyleBackColor = true;
            btnPregledStolova.Click += btnPregledStolova_Click;
            // 
            // btnPregledNarudzbi
            // 
            btnPregledNarudzbi.Location = new Point(220, 27);
            btnPregledNarudzbi.Name = "btnPregledNarudzbi";
            btnPregledNarudzbi.Size = new Size(162, 112);
            btnPregledNarudzbi.TabIndex = 2;
            btnPregledNarudzbi.Text = "Pregled narudžbi";
            btnPregledNarudzbi.UseVisualStyleBackColor = true;
            btnPregledNarudzbi.Click += btnPregledNarudzbi_Click;
            // 
            // btnNovaNarudzba
            // 
            btnNovaNarudzba.Location = new Point(28, 27);
            btnNovaNarudzba.Name = "btnNovaNarudzba";
            btnNovaNarudzba.Size = new Size(162, 112);
            btnNovaNarudzba.TabIndex = 4;
            btnNovaNarudzba.Text = "Nova narudžba";
            btnNovaNarudzba.UseVisualStyleBackColor = true;
            btnNovaNarudzba.Click += btnNovaNarudzba_Click_1;
            // 
            // btnNaplata
            // 
            btnNaplata.Location = new Point(416, 27);
            btnNaplata.Name = "btnNaplata";
            btnNaplata.Size = new Size(162, 112);
            btnNaplata.TabIndex = 5;
            btnNaplata.Text = "Naplata";
            btnNaplata.UseVisualStyleBackColor = true;
            btnNaplata.Click += btnNaplata_Click;
            // 
            // btnNovaRezervacija
            // 
            btnNovaRezervacija.Location = new Point(28, 166);
            btnNovaRezervacija.Name = "btnNovaRezervacija";
            btnNovaRezervacija.Size = new Size(162, 112);
            btnNovaRezervacija.TabIndex = 7;
            btnNovaRezervacija.Text = "Nova rezervacija";
            btnNovaRezervacija.UseVisualStyleBackColor = true;
            btnNovaRezervacija.Click += btnNovaRezervacija_Click;
            // 
            // btnPregledRezervacija
            // 
            btnPregledRezervacija.Location = new Point(220, 166);
            btnPregledRezervacija.Name = "btnPregledRezervacija";
            btnPregledRezervacija.Size = new Size(162, 112);
            btnPregledRezervacija.TabIndex = 6;
            btnPregledRezervacija.Text = "Pregled rezervacija";
            btnPregledRezervacija.UseVisualStyleBackColor = true;
            btnPregledRezervacija.Click += button2_Click;
            // 
            // FrmIzbornik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 441);
            Controls.Add(btnNovaRezervacija);
            Controls.Add(btnPregledRezervacija);
            Controls.Add(btnNaplata);
            Controls.Add(btnNovaNarudzba);
            Controls.Add(btnPregledNarudzbi);
            Controls.Add(btnPregledStolova);
            Controls.Add(btnPregledDjelatnika);
            Name = "FrmIzbornik";
            Text = "Izbornik";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPregledDjelatnika;
        private Button btnPregledStolova;
        private Button btnPregledNarudzbi;
        private Button btnNovaNarudzba;
        private Button btnNaplata;
        private Button btnNovaRezervacija;
        private Button btnPregledRezervacija;
    }
}