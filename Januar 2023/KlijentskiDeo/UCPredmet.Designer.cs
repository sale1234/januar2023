
namespace KlijentskiDeo
{
    partial class UCPredmet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifraPredmeta = new System.Windows.Forms.TextBox();
            this.txtNazivPredmeta = new System.Windows.Forms.TextBox();
            this.txtKodPredmeta = new System.Windows.Forms.TextBox();
            this.txtBrojESPB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProfesori = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnDodajAngazovanje = new System.Windows.Forms.Button();
            this.dgvAngazovanja = new System.Windows.Forms.DataGridView();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazovanja)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sifra predmeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Naziv predmeta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kod predmeta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Broj ESPB";
            // 
            // txtSifraPredmeta
            // 
            this.txtSifraPredmeta.Location = new System.Drawing.Point(212, 42);
            this.txtSifraPredmeta.Name = "txtSifraPredmeta";
            this.txtSifraPredmeta.Size = new System.Drawing.Size(152, 22);
            this.txtSifraPredmeta.TabIndex = 6;
            // 
            // txtNazivPredmeta
            // 
            this.txtNazivPredmeta.Location = new System.Drawing.Point(212, 94);
            this.txtNazivPredmeta.Name = "txtNazivPredmeta";
            this.txtNazivPredmeta.Size = new System.Drawing.Size(152, 22);
            this.txtNazivPredmeta.TabIndex = 7;
            // 
            // txtKodPredmeta
            // 
            this.txtKodPredmeta.Location = new System.Drawing.Point(212, 147);
            this.txtKodPredmeta.Name = "txtKodPredmeta";
            this.txtKodPredmeta.Size = new System.Drawing.Size(152, 22);
            this.txtKodPredmeta.TabIndex = 8;
            // 
            // txtBrojESPB
            // 
            this.txtBrojESPB.Location = new System.Drawing.Point(212, 200);
            this.txtBrojESPB.Name = "txtBrojESPB";
            this.txtBrojESPB.Size = new System.Drawing.Size(152, 22);
            this.txtBrojESPB.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAngazovanja);
            this.groupBox1.Controls.Add(this.btnDodajAngazovanje);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbProfesori);
            this.groupBox1.Location = new System.Drawing.Point(30, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 401);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Angazovanje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Profesor";
            // 
            // cbProfesori
            // 
            this.cbProfesori.FormattingEnabled = true;
            this.cbProfesori.Location = new System.Drawing.Point(182, 35);
            this.cbProfesori.Name = "cbProfesori";
            this.cbProfesori.Size = new System.Drawing.Size(152, 24);
            this.cbProfesori.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Datum";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(182, 86);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpDatum.TabIndex = 5;
            // 
            // btnDodajAngazovanje
            // 
            this.btnDodajAngazovanje.Location = new System.Drawing.Point(182, 141);
            this.btnDodajAngazovanje.Name = "btnDodajAngazovanje";
            this.btnDodajAngazovanje.Size = new System.Drawing.Size(152, 32);
            this.btnDodajAngazovanje.TabIndex = 6;
            this.btnDodajAngazovanje.Text = "Dodaj angazovanje";
            this.btnDodajAngazovanje.UseVisualStyleBackColor = true;
            this.btnDodajAngazovanje.Click += new System.EventHandler(this.btnDodajAngazovanje_Click);
            // 
            // dgvAngazovanja
            // 
            this.dgvAngazovanja.AllowUserToAddRows = false;
            this.dgvAngazovanja.AllowUserToDeleteRows = false;
            this.dgvAngazovanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAngazovanja.Location = new System.Drawing.Point(29, 190);
            this.dgvAngazovanja.Name = "dgvAngazovanja";
            this.dgvAngazovanja.ReadOnly = true;
            this.dgvAngazovanja.RowHeadersWidth = 51;
            this.dgvAngazovanja.RowTemplate.Height = 24;
            this.dgvAngazovanja.Size = new System.Drawing.Size(395, 177);
            this.dgvAngazovanja.TabIndex = 7;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(59, 668);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(395, 32);
            this.btnSacuvaj.TabIndex = 11;
            this.btnSacuvaj.Text = "Sacuvaj predmet i angazovanja";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // UCPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBrojESPB);
            this.Controls.Add(this.txtKodPredmeta);
            this.Controls.Add(this.txtNazivPredmeta);
            this.Controls.Add(this.txtSifraPredmeta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UCPredmet";
            this.Size = new System.Drawing.Size(566, 735);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazovanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifraPredmeta;
        private System.Windows.Forms.TextBox txtNazivPredmeta;
        private System.Windows.Forms.TextBox txtKodPredmeta;
        private System.Windows.Forms.TextBox txtBrojESPB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProfesori;
        private System.Windows.Forms.DataGridView dgvAngazovanja;
        private System.Windows.Forms.Button btnDodajAngazovanje;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}
