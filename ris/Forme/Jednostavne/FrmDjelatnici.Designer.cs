namespace ris.Forme.Jednostavne
{
    partial class FrmDjelatnici
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
            dgvDjelatnici = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDjelatnici).BeginInit();
            SuspendLayout();
            // 
            // dgvDjelatnici
            // 
            dgvDjelatnici.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDjelatnici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDjelatnici.Location = new Point(12, 12);
            dgvDjelatnici.Name = "dgvDjelatnici";
            dgvDjelatnici.RowHeadersWidth = 51;
            dgvDjelatnici.Size = new Size(776, 270);
            dgvDjelatnici.TabIndex = 0;
            // 
            // FrmDjelatnici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDjelatnici);
            Name = "FrmDjelatnici";
            Text = "FrmDjelatnici";
            Load += FrmDjelatnici_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDjelatnici).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDjelatnici;
    }
}