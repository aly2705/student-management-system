namespace Centralizator_Situatii_Studenti
{
    partial class CentralForm
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
            this.autentificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veziUtilizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veziCursuriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.situatiiCursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriereCursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oferaRatingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validareNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veziGraficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelShowUsers = new System.Windows.Forms.Panel();
            this.lvStudenti = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.An = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grupa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Serie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FormaFinantare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Specializare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvProfesori = new System.Windows.Forms.ListView();
            this.IdProf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumeProf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SexProf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cursuriPredate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelShowCourses = new System.Windows.Forms.Panel();
            this.lvCursuri = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelShowSituatii = new System.Windows.Forms.Panel();
            this.lvSituatii = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myDataControl1 = new Centralizator_Situatii_Studenti.MyDataControl();
            this.menuStrip1.SuspendLayout();
            this.panelShowUsers.SuspendLayout();
            this.panelShowCourses.SuspendLayout();
            this.panelShowSituatii.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autentificareToolStripMenuItem,
            this.veziUtilizatoriToolStripMenuItem,
            this.veziCursuriToolStripMenuItem,
            this.administrareToolStripMenuItem,
            this.situatiiCursToolStripMenuItem,
            this.inscriereCursToolStripMenuItem,
            this.oferaRatingMenuItem,
            this.validareNoteToolStripMenuItem,
            this.veziGraficeToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.menuStrip1.Size = new System.Drawing.Size(974, 40);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // autentificareToolStripMenuItem
            // 
            this.autentificareToolStripMenuItem.Name = "autentificareToolStripMenuItem";
            this.autentificareToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.autentificareToolStripMenuItem.Text = "Autentificare";
            this.autentificareToolStripMenuItem.Click += new System.EventHandler(this.autentificareToolStripMenuItem_Click);
            // 
            // veziUtilizatoriToolStripMenuItem
            // 
            this.veziUtilizatoriToolStripMenuItem.Name = "veziUtilizatoriToolStripMenuItem";
            this.veziUtilizatoriToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.veziUtilizatoriToolStripMenuItem.Text = "Vezi Utilizatori";
            this.veziUtilizatoriToolStripMenuItem.Click += new System.EventHandler(this.veziUtilizatoriToolStripMenuItem_Click);
            // 
            // veziCursuriToolStripMenuItem
            // 
            this.veziCursuriToolStripMenuItem.Name = "veziCursuriToolStripMenuItem";
            this.veziCursuriToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.veziCursuriToolStripMenuItem.Text = "Vezi Cursuri";
            this.veziCursuriToolStripMenuItem.Click += new System.EventHandler(this.veziCursuriToolStripMenuItem_Click);
            // 
            // administrareToolStripMenuItem
            // 
            this.administrareToolStripMenuItem.Name = "administrareToolStripMenuItem";
            this.administrareToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.administrareToolStripMenuItem.Text = "Administrare";
            this.administrareToolStripMenuItem.Click += new System.EventHandler(this.administrareToolStripMenuItem_Click);
            // 
            // situatiiCursToolStripMenuItem
            // 
            this.situatiiCursToolStripMenuItem.Name = "situatiiCursToolStripMenuItem";
            this.situatiiCursToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.situatiiCursToolStripMenuItem.Text = "Situatii Curs";
            this.situatiiCursToolStripMenuItem.Click += new System.EventHandler(this.situatiiCursToolStripMenuItem_Click);
            // 
            // inscriereCursToolStripMenuItem
            // 
            this.inscriereCursToolStripMenuItem.Name = "inscriereCursToolStripMenuItem";
            this.inscriereCursToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.inscriereCursToolStripMenuItem.Text = "Inscriere curs";
            this.inscriereCursToolStripMenuItem.Click += new System.EventHandler(this.inscriereCursToolStripMenuItem_Click);
            // 
            // oferaRatingMenuItem
            // 
            this.oferaRatingMenuItem.Name = "oferaRatingMenuItem";
            this.oferaRatingMenuItem.Size = new System.Drawing.Size(107, 24);
            this.oferaRatingMenuItem.Text = "Ofera Rating";
            this.oferaRatingMenuItem.Click += new System.EventHandler(this.oferaRatingMenuItem_Click);
            // 
            // validareNoteToolStripMenuItem
            // 
            this.validareNoteToolStripMenuItem.Name = "validareNoteToolStripMenuItem";
            this.validareNoteToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.validareNoteToolStripMenuItem.Text = "Validare Note Studenti";
            this.validareNoteToolStripMenuItem.Click += new System.EventHandler(this.validareNoteToolStripMenuItem_Click);
            // 
            // veziGraficeToolStripMenuItem
            // 
            this.veziGraficeToolStripMenuItem.Name = "veziGraficeToolStripMenuItem";
            this.veziGraficeToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.veziGraficeToolStripMenuItem.Text = "Vezi Grafice";
            this.veziGraficeToolStripMenuItem.ToolTipText = "Vezi Grafice";
            this.veziGraficeToolStripMenuItem.Click += new System.EventHandler(this.veziGraficeToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // panelShowUsers
            // 
            this.panelShowUsers.Controls.Add(this.lvStudenti);
            this.panelShowUsers.Controls.Add(this.lvProfesori);
            this.panelShowUsers.Location = new System.Drawing.Point(57, 85);
            this.panelShowUsers.Name = "panelShowUsers";
            this.panelShowUsers.Size = new System.Drawing.Size(756, 438);
            this.panelShowUsers.TabIndex = 7;
            // 
            // lvStudenti
            // 
            this.lvStudenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nume,
            this.Sex,
            this.An,
            this.Grupa,
            this.Serie,
            this.FormaFinantare,
            this.Specializare});
            this.lvStudenti.FullRowSelect = true;
            this.lvStudenti.GridLines = true;
            this.lvStudenti.HideSelection = false;
            this.lvStudenti.Location = new System.Drawing.Point(22, 14);
            this.lvStudenti.Name = "lvStudenti";
            this.lvStudenti.Size = new System.Drawing.Size(702, 178);
            this.lvStudenti.TabIndex = 0;
            this.lvStudenti.UseCompatibleStateImageBehavior = false;
            this.lvStudenti.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id Student";
            this.Id.Width = 110;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 140;
            // 
            // Sex
            // 
            this.Sex.Text = "Sex";
            this.Sex.Width = 40;
            // 
            // An
            // 
            this.An.Text = "An";
            this.An.Width = 40;
            // 
            // Grupa
            // 
            this.Grupa.Text = "Grupa";
            // 
            // Serie
            // 
            this.Serie.Text = "Serie";
            this.Serie.Width = 50;
            // 
            // FormaFinantare
            // 
            this.FormaFinantare.Text = "Forma Finantare";
            this.FormaFinantare.Width = 120;
            // 
            // Specializare
            // 
            this.Specializare.Text = "Specializare";
            this.Specializare.Width = 120;
            // 
            // lvProfesori
            // 
            this.lvProfesori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdProf,
            this.NumeProf,
            this.SexProf,
            this.cursuriPredate});
            this.lvProfesori.GridLines = true;
            this.lvProfesori.HideSelection = false;
            this.lvProfesori.Location = new System.Drawing.Point(22, 218);
            this.lvProfesori.Name = "lvProfesori";
            this.lvProfesori.Size = new System.Drawing.Size(702, 184);
            this.lvProfesori.TabIndex = 1;
            this.lvProfesori.UseCompatibleStateImageBehavior = false;
            this.lvProfesori.View = System.Windows.Forms.View.Details;
            // 
            // IdProf
            // 
            this.IdProf.Text = "Id Profesor";
            this.IdProf.Width = 110;
            // 
            // NumeProf
            // 
            this.NumeProf.Text = "Nume";
            this.NumeProf.Width = 140;
            // 
            // SexProf
            // 
            this.SexProf.Text = "Sex";
            this.SexProf.Width = 40;
            // 
            // cursuriPredate
            // 
            this.cursuriPredate.Text = "Cursuri Predate";
            this.cursuriPredate.Width = 388;
            // 
            // panelShowCourses
            // 
            this.panelShowCourses.BackColor = System.Drawing.SystemColors.Window;
            this.panelShowCourses.Controls.Add(this.lvCursuri);
            this.panelShowCourses.Location = new System.Drawing.Point(54, 85);
            this.panelShowCourses.Name = "panelShowCourses";
            this.panelShowCourses.Size = new System.Drawing.Size(771, 441);
            this.panelShowCourses.TabIndex = 8;
            // 
            // lvCursuri
            // 
            this.lvCursuri.BackColor = System.Drawing.SystemColors.Window;
            this.lvCursuri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvCursuri.GridLines = true;
            this.lvCursuri.HideSelection = false;
            this.lvCursuri.Location = new System.Drawing.Point(52, 14);
            this.lvCursuri.Name = "lvCursuri";
            this.lvCursuri.Size = new System.Drawing.Size(663, 427);
            this.lvCursuri.TabIndex = 0;
            this.lvCursuri.UseCompatibleStateImageBehavior = false;
            this.lvCursuri.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cod Curs";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Denumire Curs";
            this.columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Credite ECTS";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Procent Seminar";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Procent Examen";
            this.columnHeader5.Width = 130;
            // 
            // panelShowSituatii
            // 
            this.panelShowSituatii.Controls.Add(this.lvSituatii);
            this.panelShowSituatii.Location = new System.Drawing.Point(44, 99);
            this.panelShowSituatii.Name = "panelShowSituatii";
            this.panelShowSituatii.Size = new System.Drawing.Size(797, 409);
            this.panelShowSituatii.TabIndex = 9;
            // 
            // lvSituatii
            // 
            this.lvSituatii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader12,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvSituatii.GridLines = true;
            this.lvSituatii.HideSelection = false;
            this.lvSituatii.Location = new System.Drawing.Point(39, 29);
            this.lvSituatii.Name = "lvSituatii";
            this.lvSituatii.Size = new System.Drawing.Size(681, 339);
            this.lvSituatii.TabIndex = 0;
            this.lvSituatii.UseCompatibleStateImageBehavior = false;
            this.lvSituatii.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Curs";
            this.columnHeader6.Width = 210;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Profesor";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ECTS";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Status";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 95;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Seminar";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Examen";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Nota Finala";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 80;
            // 
            // myDataControl1
            // 
            this.myDataControl1.BackColor = System.Drawing.SystemColors.Window;
            this.myDataControl1.Location = new System.Drawing.Point(12, 571);
            this.myDataControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.myDataControl1.Name = "myDataControl1";
            this.myDataControl1.Size = new System.Drawing.Size(341, 72);
            this.myDataControl1.TabIndex = 10;
            // 
            // CentralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(974, 647);
            this.Controls.Add(this.myDataControl1);
            this.Controls.Add(this.panelShowCourses);
            this.Controls.Add(this.panelShowUsers);
            this.Controls.Add(this.panelShowSituatii);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CentralForm";
            this.Text = "Centralizator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelShowUsers.ResumeLayout(false);
            this.panelShowCourses.ResumeLayout(false);
            this.panelShowSituatii.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veziUtilizatoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veziCursuriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autentificareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem situatiiCursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriereCursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validareNoteToolStripMenuItem;
        private System.Windows.Forms.Panel panelShowUsers;
        private System.Windows.Forms.ListView lvStudenti;
        private System.Windows.Forms.ListView lvProfesori;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Sex;
        private System.Windows.Forms.ColumnHeader An;
        private System.Windows.Forms.ColumnHeader Grupa;
        private System.Windows.Forms.ColumnHeader Serie;
        private System.Windows.Forms.ColumnHeader FormaFinantare;
        private System.Windows.Forms.ColumnHeader Specializare;
        private System.Windows.Forms.ColumnHeader IdProf;
        private System.Windows.Forms.ColumnHeader NumeProf;
        private System.Windows.Forms.ColumnHeader SexProf;
        private System.Windows.Forms.ColumnHeader cursuriPredate;
        private System.Windows.Forms.Panel panelShowCourses;
        private System.Windows.Forms.ListView lvCursuri;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panelShowSituatii;
        private System.Windows.Forms.ListView lvSituatii;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ToolStripMenuItem veziGraficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oferaRatingMenuItem;
        private MyDataControl myDataControl1;
    }
}

