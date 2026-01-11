namespace ris.Forme.Jednostavne
{
    partial class frmStolovi
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
            dgvStolovi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStolovi).BeginInit();
            SuspendLayout();
            // 
            // dgvStolovi
            // 
            dgvStolovi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStolovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStolovi.Location = new Point(12, 12);
            dgvStolovi.Name = "dgvStolovi";
            dgvStolovi.RowHeadersWidth = 51;
            dgvStolovi.Size = new Size(776, 188);
            dgvStolovi.TabIndex = 0;
            // 
            // frmStolovi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStolovi);
            Name = "frmStolovi";
            Text = "frmStolovi";
            Load += frmStolovi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStolovi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStolovi;
    }
}