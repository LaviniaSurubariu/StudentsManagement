namespace Situatii_Note_Studenti
{
    partial class ScriereXML
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
            this.dgvlistStudXML = new System.Windows.Forms.DataGridView();
            this.btnGenereazaXML = new System.Windows.Forms.Button();
            this.lbListaStudenti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistStudXML)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistStudXML
            // 
            this.dgvlistStudXML.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.dgvlistStudXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistStudXML.Location = new System.Drawing.Point(0, 52);
            this.dgvlistStudXML.Name = "dgvlistStudXML";
            this.dgvlistStudXML.RowHeadersWidth = 51;
            this.dgvlistStudXML.RowTemplate.Height = 24;
            this.dgvlistStudXML.Size = new System.Drawing.Size(800, 350);
            this.dgvlistStudXML.TabIndex = 0;
            // 
            // btnGenereazaXML
            // 
            this.btnGenereazaXML.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenereazaXML.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenereazaXML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(157)))), ((int)(((byte)(219)))));
            this.btnGenereazaXML.Location = new System.Drawing.Point(0, 397);
            this.btnGenereazaXML.Name = "btnGenereazaXML";
            this.btnGenereazaXML.Size = new System.Drawing.Size(740, 53);
            this.btnGenereazaXML.TabIndex = 1;
            this.btnGenereazaXML.Text = "Generati Document XML";
            this.btnGenereazaXML.UseVisualStyleBackColor = true;
            this.btnGenereazaXML.Click += new System.EventHandler(this.btnGenereazaXML_Click);
            // 
            // lbListaStudenti
            // 
            this.lbListaStudenti.AutoSize = true;
            this.lbListaStudenti.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListaStudenti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(157)))), ((int)(((byte)(219)))));
            this.lbListaStudenti.Location = new System.Drawing.Point(248, 9);
            this.lbListaStudenti.Name = "lbListaStudenti";
            this.lbListaStudenti.Size = new System.Drawing.Size(248, 36);
            this.lbListaStudenti.TabIndex = 2;
            this.lbListaStudenti.Text = "Lista Studenti";
            // 
            // ScriereXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.lbListaStudenti);
            this.Controls.Add(this.btnGenereazaXML);
            this.Controls.Add(this.dgvlistStudXML);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ScriereXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScriereXML";
            this.Load += new System.EventHandler(this.ScriereXML_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistStudXML)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistStudXML;
        private System.Windows.Forms.Button btnGenereazaXML;
        private System.Windows.Forms.Label lbListaStudenti;
    }
}