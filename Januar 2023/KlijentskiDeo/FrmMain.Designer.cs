
namespace KlijentskiDeo
{
    partial class FrmMain
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
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajProfesoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPredmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazPredmetaNaKojimaJeAngazovanProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.angazovanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(692, 762);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(0, 17);
            this.lblKorisnik.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajProfesoraToolStripMenuItem,
            this.dodajPredmetToolStripMenuItem,
            this.prikazPredmetaNaKojimaJeAngazovanProfesorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.angazovanjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajProfesoraToolStripMenuItem
            // 
            this.dodajProfesoraToolStripMenuItem.Name = "dodajProfesoraToolStripMenuItem";
            this.dodajProfesoraToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.dodajProfesoraToolStripMenuItem.Text = "Dodaj profesora";
            this.dodajProfesoraToolStripMenuItem.Click += new System.EventHandler(this.dodajProfesoraToolStripMenuItem_Click);
            // 
            // dodajPredmetToolStripMenuItem
            // 
            this.dodajPredmetToolStripMenuItem.Name = "dodajPredmetToolStripMenuItem";
            this.dodajPredmetToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.dodajPredmetToolStripMenuItem.Text = "Dodaj predmet i angazovanja";
            this.dodajPredmetToolStripMenuItem.Click += new System.EventHandler(this.dodajPredmetToolStripMenuItem_Click);
            // 
            // prikazPredmetaNaKojimaJeAngazovanProfesorToolStripMenuItem
            // 
            this.prikazPredmetaNaKojimaJeAngazovanProfesorToolStripMenuItem.Name = "prikazPredmetaNaKojimaJeAngazovanProfesorToolStripMenuItem";
            this.prikazPredmetaNaKojimaJeAngazovanProfesorToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.prikazPredmetaNaKojimaJeAngazovanProfesorToolStripMenuItem.Text = "Prikaz predmeta";
            this.prikazPredmetaNaKojimaJeAngazovanProfesorToolStripMenuItem.Click += new System.EventHandler(this.prikazPredmetaNaKojimaJeAngazovanProfesorToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(27, 55);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(624, 724);
            this.pnlMain.TabIndex = 2;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(14, 24);
            // 
            // angazovanjaToolStripMenuItem
            // 
            this.angazovanjaToolStripMenuItem.Name = "angazovanjaToolStripMenuItem";
            this.angazovanjaToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.angazovanjaToolStripMenuItem.Text = "Angazovanja";
            this.angazovanjaToolStripMenuItem.Click += new System.EventHandler(this.angazovanjaToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 922);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajProfesoraToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem dodajPredmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazPredmetaNaKojimaJeAngazovanProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem angazovanjaToolStripMenuItem;
    }
}