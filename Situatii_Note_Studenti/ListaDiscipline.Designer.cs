namespace Situatii_Note_Studenti
{
    partial class ListaDiscipline
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
            this.dgvListaDiscipline = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDiscipline)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaDiscipline
            // 
            this.dgvListaDiscipline.AllowDrop = true;
            this.dgvListaDiscipline.AllowUserToOrderColumns = true;
            this.dgvListaDiscipline.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.dgvListaDiscipline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDiscipline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaDiscipline.Location = new System.Drawing.Point(0, 0);
            this.dgvListaDiscipline.Name = "dgvListaDiscipline";
            this.dgvListaDiscipline.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvListaDiscipline.RowTemplate.Height = 24;
            this.dgvListaDiscipline.Size = new System.Drawing.Size(593, 299);
            this.dgvListaDiscipline.TabIndex = 0;
            this.dgvListaDiscipline.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaDiscipline_CellContentClick);
            // 
            // ListaDiscipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 299);
            this.Controls.Add(this.dgvListaDiscipline);
            this.Name = "ListaDiscipline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaDiscipline";
            this.Load += new System.EventHandler(this.ListaDiscipline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDiscipline)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDiscipline;
    }
}