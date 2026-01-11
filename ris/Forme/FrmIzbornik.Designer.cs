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
            SuspendLayout();
            // 
            // btnPregledDjelatnika
            // 
            btnPregledDjelatnika.Location = new Point(39, 58);
            btnPregledDjelatnika.Name = "btnPregledDjelatnika";
            btnPregledDjelatnika.Size = new Size(162, 38);
            btnPregledDjelatnika.TabIndex = 0;
            btnPregledDjelatnika.Text = "Pregled djelatnika";
            btnPregledDjelatnika.UseVisualStyleBackColor = true;
            btnPregledDjelatnika.Click += btnPregledDjelatnika_Click;
            // 
            // FrmIzbornik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPregledDjelatnika);
            Name = "FrmIzbornik";
            Text = "Izbornik";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPregledDjelatnika;
    }
}