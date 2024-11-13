
namespace ServerskiDeo
{
    partial class FrmServer
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
            this.btnStart = new System.Windows.Forms.Button();
            this.dgvProfesori = new System.Windows.Forms.DataGridView();
            this.dgvZvanje = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZvanje)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(62, 56);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(138, 43);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Pokreni server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dgvProfesori
            // 
            this.dgvProfesori.AllowUserToAddRows = false;
            this.dgvProfesori.AllowUserToDeleteRows = false;
            this.dgvProfesori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesori.Location = new System.Drawing.Point(62, 121);
            this.dgvProfesori.Name = "dgvProfesori";
            this.dgvProfesori.ReadOnly = true;
            this.dgvProfesori.RowHeadersWidth = 51;
            this.dgvProfesori.RowTemplate.Height = 24;
            this.dgvProfesori.Size = new System.Drawing.Size(552, 213);
            this.dgvProfesori.TabIndex = 1;
            // 
            // dgvZvanje
            // 
            this.dgvZvanje.AllowUserToAddRows = false;
            this.dgvZvanje.AllowUserToDeleteRows = false;
            this.dgvZvanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZvanje.Location = new System.Drawing.Point(62, 381);
            this.dgvZvanje.Name = "dgvZvanje";
            this.dgvZvanje.ReadOnly = true;
            this.dgvZvanje.RowHeadersWidth = 51;
            this.dgvZvanje.RowTemplate.Height = 24;
            this.dgvZvanje.Size = new System.Drawing.Size(552, 213);
            this.dgvZvanje.TabIndex = 2;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 665);
            this.Controls.Add(this.dgvZvanje);
            this.Controls.Add(this.dgvProfesori);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmServer";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZvanje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dgvProfesori;
        private System.Windows.Forms.DataGridView dgvZvanje;
    }
}

