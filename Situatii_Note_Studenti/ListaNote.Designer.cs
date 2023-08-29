namespace Situatii_Note_Studenti
{
    partial class ListaNote
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
            this.dgvListaNote = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaNote)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaNote
            // 
            this.dgvListaNote.AllowDrop = true;
            this.dgvListaNote.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaNote.Location = new System.Drawing.Point(0, 0);
            this.dgvListaNote.Name = "dgvListaNote";
            this.dgvListaNote.RowHeadersWidth = 51;
            this.dgvListaNote.RowTemplate.Height = 24;
            this.dgvListaNote.Size = new System.Drawing.Size(613, 452);
            this.dgvListaNote.TabIndex = 0;
            this.dgvListaNote.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaNote_CellContentClick);
            this.dgvListaNote.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvListaNote_DragDrop);
            this.dgvListaNote.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvListaNote_DragOver);
            this.dgvListaNote.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvListaNote_MouseMove);
            // 
            // ListaNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 452);
            this.Controls.Add(this.dgvListaNote);
            this.Name = "ListaNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaNote";
            this.Load += new System.EventHandler(this.ListaNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaNote;
    }
}