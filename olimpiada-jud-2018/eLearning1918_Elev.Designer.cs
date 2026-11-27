namespace olimpiada_jud_2018
{
    partial class eLearning1918_Elev
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.elevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carnetDeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabElev = new System.Windows.Forms.TabControl();
            this.tabTeste = new System.Windows.Forms.TabPage();
            this.tabCarnetNote = new System.Windows.Forms.TabPage();
            this.tabGrafic = new System.Windows.Forms.TabPage();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPunctaj = new System.Windows.Forms.Label();
            this.lblEnunt = new System.Windows.Forms.Label();
            this.btnRaspuns = new System.Windows.Forms.Button();
            this.btnUrmatorul = new System.Windows.Forms.Button();
            this.lblNume = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabElev.SuspendLayout();
            this.tabTeste.SuspendLayout();
            this.tabCarnetNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elevToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // elevToolStripMenuItem
            // 
            this.elevToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem,
            this.carnetDeNoteToolStripMenuItem,
            this.graficNoteToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.elevToolStripMenuItem.Name = "elevToolStripMenuItem";
            this.elevToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.elevToolStripMenuItem.Text = "Elev";
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testeToolStripMenuItem.Text = "Teste";
            this.testeToolStripMenuItem.Click += new System.EventHandler(this.testeToolStripMenuItem_Click);
            // 
            // carnetDeNoteToolStripMenuItem
            // 
            this.carnetDeNoteToolStripMenuItem.Name = "carnetDeNoteToolStripMenuItem";
            this.carnetDeNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carnetDeNoteToolStripMenuItem.Text = "Carnet de note";
            this.carnetDeNoteToolStripMenuItem.Click += new System.EventHandler(this.carnetDeNoteToolStripMenuItem_Click);
            // 
            // graficNoteToolStripMenuItem
            // 
            this.graficNoteToolStripMenuItem.Name = "graficNoteToolStripMenuItem";
            this.graficNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.graficNoteToolStripMenuItem.Text = "Grafic note";
            this.graficNoteToolStripMenuItem.Click += new System.EventHandler(this.graficNoteToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // tabElev
            // 
            this.tabElev.Controls.Add(this.tabTeste);
            this.tabElev.Controls.Add(this.tabCarnetNote);
            this.tabElev.Controls.Add(this.tabGrafic);
            this.tabElev.Location = new System.Drawing.Point(25, 57);
            this.tabElev.Name = "tabElev";
            this.tabElev.SelectedIndex = 0;
            this.tabElev.Size = new System.Drawing.Size(666, 309);
            this.tabElev.TabIndex = 1;
            // 
            // tabTeste
            // 
            this.tabTeste.Controls.Add(this.btnUrmatorul);
            this.tabTeste.Controls.Add(this.btnRaspuns);
            this.tabTeste.Controls.Add(this.lblEnunt);
            this.tabTeste.Controls.Add(this.lblPunctaj);
            this.tabTeste.Controls.Add(this.btnStart);
            this.tabTeste.Location = new System.Drawing.Point(4, 24);
            this.tabTeste.Name = "tabTeste";
            this.tabTeste.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeste.Size = new System.Drawing.Size(658, 281);
            this.tabTeste.TabIndex = 0;
            this.tabTeste.Text = "Teste";
            this.tabTeste.UseVisualStyleBackColor = true;
            // 
            // tabCarnetNote
            // 
            this.tabCarnetNote.Controls.Add(this.btnPrint);
            this.tabCarnetNote.Controls.Add(this.dataGridView1);
            this.tabCarnetNote.Controls.Add(this.lblNume);
            this.tabCarnetNote.Location = new System.Drawing.Point(4, 24);
            this.tabCarnetNote.Name = "tabCarnetNote";
            this.tabCarnetNote.Padding = new System.Windows.Forms.Padding(3);
            this.tabCarnetNote.Size = new System.Drawing.Size(658, 281);
            this.tabCarnetNote.TabIndex = 1;
            this.tabCarnetNote.Text = "Carnet de note";
            this.tabCarnetNote.UseVisualStyleBackColor = true;
            // 
            // tabGrafic
            // 
            this.tabGrafic.Location = new System.Drawing.Point(4, 24);
            this.tabGrafic.Name = "tabGrafic";
            this.tabGrafic.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrafic.Size = new System.Drawing.Size(658, 281);
            this.tabGrafic.TabIndex = 2;
            this.tabGrafic.Text = "Grafic note";
            this.tabGrafic.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(480, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // lblPunctaj
            // 
            this.lblPunctaj.AutoSize = true;
            this.lblPunctaj.Location = new System.Drawing.Point(36, 22);
            this.lblPunctaj.Name = "lblPunctaj";
            this.lblPunctaj.Size = new System.Drawing.Size(62, 15);
            this.lblPunctaj.TabIndex = 1;
            this.lblPunctaj.Text = "Punctaj: 1";
            // 
            // lblEnunt
            // 
            this.lblEnunt.AutoSize = true;
            this.lblEnunt.Location = new System.Drawing.Point(22, 62);
            this.lblEnunt.Name = "lblEnunt";
            this.lblEnunt.Size = new System.Drawing.Size(38, 15);
            this.lblEnunt.TabIndex = 2;
            this.lblEnunt.Text = "Enunt";
            // 
            // btnRaspuns
            // 
            this.btnRaspuns.Location = new System.Drawing.Point(333, 100);
            this.btnRaspuns.Name = "btnRaspuns";
            this.btnRaspuns.Size = new System.Drawing.Size(112, 34);
            this.btnRaspuns.TabIndex = 3;
            this.btnRaspuns.Text = "Raspunde";
            this.btnRaspuns.UseVisualStyleBackColor = true;
            this.btnRaspuns.Visible = false;
            // 
            // btnUrmatorul
            // 
            this.btnUrmatorul.Location = new System.Drawing.Point(333, 151);
            this.btnUrmatorul.Name = "btnUrmatorul";
            this.btnUrmatorul.Size = new System.Drawing.Size(112, 34);
            this.btnUrmatorul.TabIndex = 4;
            this.btnUrmatorul.Text = "Urmatorul";
            this.btnUrmatorul.UseVisualStyleBackColor = true;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(45, 24);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(164, 15);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Carnetul de note al elevului: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 138);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(48, 226);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(112, 34);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // eLearning1918_Elev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(716, 483);
            this.Controls.Add(this.tabElev);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "eLearning1918_Elev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eLearning1918_Elev";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.eLearning1918_Elev_FormClosed);
            this.Load += new System.EventHandler(this.eLearning1918_Elev_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabElev.ResumeLayout(false);
            this.tabTeste.ResumeLayout(false);
            this.tabTeste.PerformLayout();
            this.tabCarnetNote.ResumeLayout(false);
            this.tabCarnetNote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem elevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carnetDeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.TabControl tabElev;
        private System.Windows.Forms.TabPage tabTeste;
        private System.Windows.Forms.TabPage tabCarnetNote;
        private System.Windows.Forms.TabPage tabGrafic;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnUrmatorul;
        private System.Windows.Forms.Button btnRaspuns;
        private System.Windows.Forms.Label lblEnunt;
        private System.Windows.Forms.Label lblPunctaj;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}