namespace Situatii_Note_Studenti
{
    partial class CitireXML
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
            this.lbListaStudenti = new System.Windows.Forms.Label();
            this.dgvlistStudXML = new System.Windows.Forms.DataGridView();
            this.btnInsereazaDinXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistStudXML)).BeginInit();
            this.SuspendLayout();
            // 
            // lbListaStudenti
            // 
            this.lbListaStudenti.AutoSize = true;
            this.lbListaStudenti.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListaStudenti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(157)))), ((int)(((byte)(219)))));
            this.lbListaStudenti.Location = new System.Drawing.Point(266, 9);
            this.lbListaStudenti.Name = "lbListaStudenti";
            this.lbListaStudenti.Size = new System.Drawing.Size(248, 36);
            this.lbListaStudenti.TabIndex = 3;
            this.lbListaStudenti.Text = "Lista Studenti";
            // 
            // dgvlistStudXML
            // 
            this.dgvlistStudXML.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.dgvlistStudXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistStudXML.Location = new System.Drawing.Point(0, 50);
            this.dgvlistStudXML.Name = "dgvlistStudXML";
            this.dgvlistStudXML.RowHeadersWidth = 51;
            this.dgvlistStudXML.RowTemplate.Height = 24;
            this.dgvlistStudXML.Size = new System.Drawing.Size(800, 350);
            this.dgvlistStudXML.TabIndex = 4;
            // 
            // btnInsereazaDinXML
            // 
            this.btnInsereazaDinXML.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInsereazaDinXML.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsereazaDinXML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(157)))), ((int)(((byte)(219)))));
            this.btnInsereazaDinXML.Location = new System.Drawing.Point(0, 397);
            this.btnInsereazaDinXML.Name = "btnInsereazaDinXML";
            this.btnInsereazaDinXML.Size = new System.Drawing.Size(737, 53);
            this.btnInsereazaDinXML.TabIndex = 5;
            this.btnInsereazaDinXML.Text = "Inserati Datele din Documentul XML";
            this.btnInsereazaDinXML.UseVisualStyleBackColor = true;
            this.btnInsereazaDinXML.Click += new System.EventHandler(this.btnInsereazaDinXML_Click);
            // 
            // CitireXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.btnInsereazaDinXML);
            this.Controls.Add(this.dgvlistStudXML);
            this.Controls.Add(this.lbListaStudenti);
            this.Name = "CitireXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CitireXML";
            this.Load += new System.EventHandler(this.CitireXML_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistStudXML)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbListaStudenti;
        private System.Windows.Forms.DataGridView dgvlistStudXML;
        private System.Windows.Forms.Button btnInsereazaDinXML;
    }
}