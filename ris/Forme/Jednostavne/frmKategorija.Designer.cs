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
            btnDodajNovu = new Button();
            btnOsvjezi = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKategorija).BeginInit();
            SuspendLayout();
            // 
            // dgvKategorija
            // 
            dgvKategorija.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKategorija.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategorija.Location = new Point(14, 12);
            dgvKategorija.Name = "dgvKategorija";
            dgvKategorija.RowHeadersWidth = 51;
            dgvKategorija.Size = new Size(773, 344);
            dgvKategorija.TabIndex = 0;
            // 
            // btnDodajNovu
            // 
            btnDodajNovu.Location = new Point(208, 381);
            btnDodajNovu.Name = "btnDodajNovu";
            btnDodajNovu.Size = new Size(170, 29);
            btnDodajNovu.TabIndex = 1;
            btnDodajNovu.Text = "Dodaj novu kategoriju";
            btnDodajNovu.UseVisualStyleBackColor = true;
            btnDodajNovu.Click += btnDodajNovu_Click;
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
            // button1
            // 
            button1.Location = new Point(384, 381);
            button1.Name = "button1";
            button1.Size = new Size(137, 29);
            button1.TabIndex = 3;
            button1.Text = "Uredi kategoriju";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(527, 381);
            button2.Name = "button2";
            button2.Size = new Size(134, 29);
            button2.TabIndex = 4;
            button2.Text = "Obriši kategoriju";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmKategorija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnOsvjezi);
            Controls.Add(btnDodajNovu);
            Controls.Add(dgvKategorija);
            Name = "frmKategorija";
            Text = "frmKategorija";
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
    }
}