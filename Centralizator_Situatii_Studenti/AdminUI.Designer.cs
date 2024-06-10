namespace Centralizator_Situatii_Studenti
{
    partial class AdminUI
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
            this.components = new System.ComponentModel.Container();
            this.panelAddStudent = new System.Windows.Forms.Panel();
            this.btnSubmitStudent = new System.Windows.Forms.Button();
            this.cbSpecializare = new System.Windows.Forms.ComboBox();
            this.cbFinantare = new System.Windows.Forms.ComboBox();
            this.lblSpecializare = new System.Windows.Forms.Label();
            this.lblFinantare = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.lbSex = new System.Windows.Forms.Label();
            this.tbGrupa = new System.Windows.Forms.TextBox();
            this.cbSerie = new System.Windows.Forms.ComboBox();
            this.cbAn = new System.Windows.Forms.ComboBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblGrupa = new System.Windows.Forms.Label();
            this.lblAn = new System.Windows.Forms.Label();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.labelSPName = new System.Windows.Forms.Label();
            this.labelSName = new System.Windows.Forms.Label();
            this.labelAddStud = new System.Windows.Forms.Label();
            this.panelAddProffesor = new System.Windows.Forms.Panel();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnAddCourseField = new System.Windows.Forms.Button();
            this.btnSubmitProf = new System.Windows.Forms.Button();
            this.cbCurs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSexProf = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrenumeProf = new System.Windows.Forms.TextBox();
            this.tbNumeProf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelAddCourse = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPondereSeminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpondereExamen = new System.Windows.Forms.TextBox();
            this.btnSubmitCourse = new System.Windows.Forms.Button();
            this.tbCredite = new System.Windows.Forms.TextBox();
            this.tbDenumireCurs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStripAdminUI = new System.Windows.Forms.MenuStrip();
            this.adaugaStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaCursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaModificariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myDataControl1 = new Centralizator_Situatii_Studenti.MyDataControl();
            this.panelAddStudent.SuspendLayout();
            this.panelAddProffesor.SuspendLayout();
            this.panelAddCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStripAdminUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddStudent
            // 
            this.panelAddStudent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAddStudent.Controls.Add(this.btnSubmitStudent);
            this.panelAddStudent.Controls.Add(this.cbSpecializare);
            this.panelAddStudent.Controls.Add(this.cbFinantare);
            this.panelAddStudent.Controls.Add(this.lblSpecializare);
            this.panelAddStudent.Controls.Add(this.lblFinantare);
            this.panelAddStudent.Controls.Add(this.cbSex);
            this.panelAddStudent.Controls.Add(this.lbSex);
            this.panelAddStudent.Controls.Add(this.tbGrupa);
            this.panelAddStudent.Controls.Add(this.cbSerie);
            this.panelAddStudent.Controls.Add(this.cbAn);
            this.panelAddStudent.Controls.Add(this.lblSerie);
            this.panelAddStudent.Controls.Add(this.lblGrupa);
            this.panelAddStudent.Controls.Add(this.lblAn);
            this.panelAddStudent.Controls.Add(this.tbPrenume);
            this.panelAddStudent.Controls.Add(this.tbNume);
            this.panelAddStudent.Controls.Add(this.labelSPName);
            this.panelAddStudent.Controls.Add(this.labelSName);
            this.panelAddStudent.Controls.Add(this.labelAddStud);
            this.panelAddStudent.Location = new System.Drawing.Point(242, 106);
            this.panelAddStudent.Name = "panelAddStudent";
            this.panelAddStudent.Size = new System.Drawing.Size(490, 419);
            this.panelAddStudent.TabIndex = 3;
            // 
            // btnSubmitStudent
            // 
            this.btnSubmitStudent.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSubmitStudent.Location = new System.Drawing.Point(229, 342);
            this.btnSubmitStudent.Name = "btnSubmitStudent";
            this.btnSubmitStudent.Size = new System.Drawing.Size(219, 47);
            this.btnSubmitStudent.TabIndex = 17;
            this.btnSubmitStudent.Text = "Salveaza Student";
            this.btnSubmitStudent.UseVisualStyleBackColor = false;
            this.btnSubmitStudent.Click += new System.EventHandler(this.btnSubmitStudent_Click);
            // 
            // cbSpecializare
            // 
            this.cbSpecializare.FormattingEnabled = true;
            this.cbSpecializare.Items.AddRange(new object[] {
            "Cibernetica",
            "Statistica",
            "Informatica"});
            this.cbSpecializare.Location = new System.Drawing.Point(268, 279);
            this.cbSpecializare.Name = "cbSpecializare";
            this.cbSpecializare.Size = new System.Drawing.Size(180, 28);
            this.cbSpecializare.TabIndex = 16;
            this.cbSpecializare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTypingNotAllowed_KeyPress);
            // 
            // cbFinantare
            // 
            this.cbFinantare.FormattingEnabled = true;
            this.cbFinantare.Items.AddRange(new object[] {
            "Buget",
            "Taxa"});
            this.cbFinantare.Location = new System.Drawing.Point(38, 279);
            this.cbFinantare.Name = "cbFinantare";
            this.cbFinantare.Size = new System.Drawing.Size(193, 28);
            this.cbFinantare.TabIndex = 15;
            this.cbFinantare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTypingNotAllowed_KeyPress);
            // 
            // lblSpecializare
            // 
            this.lblSpecializare.AutoSize = true;
            this.lblSpecializare.Location = new System.Drawing.Point(264, 251);
            this.lblSpecializare.Name = "lblSpecializare";
            this.lblSpecializare.Size = new System.Drawing.Size(98, 20);
            this.lblSpecializare.TabIndex = 14;
            this.lblSpecializare.Text = "Specializare:";
            // 
            // lblFinantare
            // 
            this.lblFinantare.AutoSize = true;
            this.lblFinantare.Location = new System.Drawing.Point(34, 251);
            this.lblFinantare.Name = "lblFinantare";
            this.lblFinantare.Size = new System.Drawing.Size(134, 20);
            this.lblFinantare.TabIndex = 13;
            this.lblFinantare.Text = "Forma Finantare:";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSex.Location = new System.Drawing.Point(355, 90);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(93, 28);
            this.cbSex.TabIndex = 12;
            this.cbSex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTypingNotAllowed_KeyPress);
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(351, 67);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(38, 20);
            this.lbSex.TabIndex = 11;
            this.lbSex.Text = "Sex:";
            // 
            // tbGrupa
            // 
            this.tbGrupa.Location = new System.Drawing.Point(186, 182);
            this.tbGrupa.Name = "tbGrupa";
            this.tbGrupa.Size = new System.Drawing.Size(141, 28);
            this.tbGrupa.TabIndex = 10;
            this.tbGrupa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOnlyNumbers_KeyPress);
            // 
            // cbSerie
            // 
            this.cbSerie.FormattingEnabled = true;
            this.cbSerie.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.cbSerie.Location = new System.Drawing.Point(355, 182);
            this.cbSerie.Name = "cbSerie";
            this.cbSerie.Size = new System.Drawing.Size(93, 28);
            this.cbSerie.TabIndex = 9;
            this.cbSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTypingNotAllowed_KeyPress);
            // 
            // cbAn
            // 
            this.cbAn.FormattingEnabled = true;
            this.cbAn.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbAn.Location = new System.Drawing.Point(38, 182);
            this.cbAn.Name = "cbAn";
            this.cbAn.Size = new System.Drawing.Size(113, 28);
            this.cbAn.TabIndex = 8;
            this.cbAn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTypingNotAllowed_KeyPress);
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(351, 159);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(49, 20);
            this.lblSerie.TabIndex = 7;
            this.lblSerie.Text = "Serie:";
            // 
            // lblGrupa
            // 
            this.lblGrupa.AutoSize = true;
            this.lblGrupa.Location = new System.Drawing.Point(182, 159);
            this.lblGrupa.Name = "lblGrupa";
            this.lblGrupa.Size = new System.Drawing.Size(58, 20);
            this.lblGrupa.TabIndex = 6;
            this.lblGrupa.Text = "Grupa:";
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(34, 159);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(33, 20);
            this.lblAn.TabIndex = 5;
            this.lblAn.Text = "An:";
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(186, 90);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(141, 28);
            this.tbPrenume.TabIndex = 4;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(38, 90);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(113, 28);
            this.tbNume.TabIndex = 3;
            // 
            // labelSPName
            // 
            this.labelSPName.AutoSize = true;
            this.labelSPName.Location = new System.Drawing.Point(182, 67);
            this.labelSPName.Name = "labelSPName";
            this.labelSPName.Size = new System.Drawing.Size(80, 20);
            this.labelSPName.TabIndex = 2;
            this.labelSPName.Text = "Prenume:";
            // 
            // labelSName
            // 
            this.labelSName.AutoSize = true;
            this.labelSName.Location = new System.Drawing.Point(34, 67);
            this.labelSName.Name = "labelSName";
            this.labelSName.Size = new System.Drawing.Size(58, 20);
            this.labelSName.TabIndex = 1;
            this.labelSName.Text = "Nume:";
            // 
            // labelAddStud
            // 
            this.labelAddStud.AutoSize = true;
            this.labelAddStud.Font = new System.Drawing.Font("Open Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddStud.Location = new System.Drawing.Point(34, 27);
            this.labelAddStud.Name = "labelAddStud";
            this.labelAddStud.Size = new System.Drawing.Size(142, 23);
            this.labelAddStud.TabIndex = 0;
            this.labelAddStud.Text = "Adauga Student";
            // 
            // panelAddProffesor
            // 
            this.panelAddProffesor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAddProffesor.Controls.Add(this.btnDeleteCourse);
            this.panelAddProffesor.Controls.Add(this.btnAddCourseField);
            this.panelAddProffesor.Controls.Add(this.btnSubmitProf);
            this.panelAddProffesor.Controls.Add(this.cbCurs);
            this.panelAddProffesor.Controls.Add(this.label2);
            this.panelAddProffesor.Controls.Add(this.cbSexProf);
            this.panelAddProffesor.Controls.Add(this.label3);
            this.panelAddProffesor.Controls.Add(this.tbPrenumeProf);
            this.panelAddProffesor.Controls.Add(this.tbNumeProf);
            this.panelAddProffesor.Controls.Add(this.label7);
            this.panelAddProffesor.Controls.Add(this.label8);
            this.panelAddProffesor.Controls.Add(this.label9);
            this.panelAddProffesor.Location = new System.Drawing.Point(242, 106);
            this.panelAddProffesor.Name = "panelAddProffesor";
            this.panelAddProffesor.Size = new System.Drawing.Size(490, 419);
            this.panelAddProffesor.TabIndex = 18;
            this.panelAddProffesor.VisibleChanged += new System.EventHandler(this.panelAddProffesor_VisibleChanged);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.MintCream;
            this.btnDeleteCourse.Location = new System.Drawing.Point(355, 232);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(93, 59);
            this.btnDeleteCourse.TabIndex = 19;
            this.btnDeleteCourse.Text = "Sterge Curs";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnAddCourseField
            // 
            this.btnAddCourseField.BackColor = System.Drawing.Color.MintCream;
            this.btnAddCourseField.Location = new System.Drawing.Point(355, 159);
            this.btnAddCourseField.Name = "btnAddCourseField";
            this.btnAddCourseField.Size = new System.Drawing.Size(93, 59);
            this.btnAddCourseField.TabIndex = 18;
            this.btnAddCourseField.Text = "Adauga Curs";
            this.btnAddCourseField.UseVisualStyleBackColor = false;
            this.btnAddCourseField.Click += new System.EventHandler(this.btnAddCourseField_Click);
            // 
            // btnSubmitProf
            // 
            this.btnSubmitProf.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSubmitProf.Location = new System.Drawing.Point(263, 342);
            this.btnSubmitProf.Name = "btnSubmitProf";
            this.btnSubmitProf.Size = new System.Drawing.Size(185, 47);
            this.btnSubmitProf.TabIndex = 17;
            this.btnSubmitProf.Text = "Salveaza Profesor";
            this.btnSubmitProf.UseVisualStyleBackColor = false;
            this.btnSubmitProf.Click += new System.EventHandler(this.btnSubmitProf_Click);
            // 
            // cbCurs
            // 
            this.cbCurs.FormattingEnabled = true;
            this.cbCurs.Location = new System.Drawing.Point(38, 168);
            this.cbCurs.Name = "cbCurs";
            this.cbCurs.Size = new System.Drawing.Size(289, 28);
            this.cbCurs.TabIndex = 15;
            this.cbCurs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTypingNotAllowed_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cursuri:";
            // 
            // cbSexProf
            // 
            this.cbSexProf.FormattingEnabled = true;
            this.cbSexProf.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexProf.Location = new System.Drawing.Point(355, 90);
            this.cbSexProf.Name = "cbSexProf";
            this.cbSexProf.Size = new System.Drawing.Size(93, 28);
            this.cbSexProf.TabIndex = 12;
            this.cbSexProf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTypingNotAllowed_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sex:";
            // 
            // tbPrenumeProf
            // 
            this.tbPrenumeProf.Location = new System.Drawing.Point(186, 90);
            this.tbPrenumeProf.Name = "tbPrenumeProf";
            this.tbPrenumeProf.Size = new System.Drawing.Size(141, 28);
            this.tbPrenumeProf.TabIndex = 4;
            // 
            // tbNumeProf
            // 
            this.tbNumeProf.Location = new System.Drawing.Point(38, 90);
            this.tbNumeProf.Name = "tbNumeProf";
            this.tbNumeProf.Size = new System.Drawing.Size(113, 28);
            this.tbNumeProf.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Prenume:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nume:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Adauga Profesor";
            // 
            // panelAddCourse
            // 
            this.panelAddCourse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAddCourse.Controls.Add(this.label4);
            this.panelAddCourse.Controls.Add(this.tbPondereSeminar);
            this.panelAddCourse.Controls.Add(this.label1);
            this.panelAddCourse.Controls.Add(this.tbpondereExamen);
            this.panelAddCourse.Controls.Add(this.btnSubmitCourse);
            this.panelAddCourse.Controls.Add(this.tbCredite);
            this.panelAddCourse.Controls.Add(this.tbDenumireCurs);
            this.panelAddCourse.Controls.Add(this.label5);
            this.panelAddCourse.Controls.Add(this.label6);
            this.panelAddCourse.Controls.Add(this.label10);
            this.panelAddCourse.Location = new System.Drawing.Point(242, 106);
            this.panelAddCourse.Name = "panelAddCourse";
            this.panelAddCourse.Size = new System.Drawing.Size(490, 307);
            this.panelAddCourse.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Pondere Seminar:";
            // 
            // tbPondereSeminar
            // 
            this.tbPondereSeminar.Location = new System.Drawing.Point(260, 159);
            this.tbPondereSeminar.Name = "tbPondereSeminar";
            this.tbPondereSeminar.Size = new System.Drawing.Size(188, 28);
            this.tbPondereSeminar.TabIndex = 20;
            this.tbPondereSeminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOnlyNumbers_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pondere Examen:";
            // 
            // tbpondereExamen
            // 
            this.tbpondereExamen.Location = new System.Drawing.Point(38, 159);
            this.tbpondereExamen.Name = "tbpondereExamen";
            this.tbpondereExamen.Size = new System.Drawing.Size(193, 28);
            this.tbpondereExamen.TabIndex = 18;
            this.tbpondereExamen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOnlyNumbers_KeyPress);
            // 
            // btnSubmitCourse
            // 
            this.btnSubmitCourse.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSubmitCourse.Location = new System.Drawing.Point(263, 216);
            this.btnSubmitCourse.Name = "btnSubmitCourse";
            this.btnSubmitCourse.Size = new System.Drawing.Size(185, 47);
            this.btnSubmitCourse.TabIndex = 17;
            this.btnSubmitCourse.Text = "Salveaza Curs";
            this.btnSubmitCourse.UseVisualStyleBackColor = false;
            this.btnSubmitCourse.Click += new System.EventHandler(this.btnSubmitCourse_Click);
            // 
            // tbCredite
            // 
            this.tbCredite.Location = new System.Drawing.Point(260, 90);
            this.tbCredite.Name = "tbCredite";
            this.tbCredite.Size = new System.Drawing.Size(188, 28);
            this.tbCredite.TabIndex = 4;
            this.tbCredite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOnlyNumbers_KeyPress);
            // 
            // tbDenumireCurs
            // 
            this.tbDenumireCurs.Location = new System.Drawing.Point(38, 90);
            this.tbDenumireCurs.Name = "tbDenumireCurs";
            this.tbDenumireCurs.Size = new System.Drawing.Size(193, 28);
            this.tbDenumireCurs.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Credite ECTS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Denumire:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Adauga Curs";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStripAdminUI
            // 
            this.menuStripAdminUI.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStripAdminUI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAdminUI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaStudentToolStripMenuItem,
            this.adaugaProfesorToolStripMenuItem,
            this.adaugaCursToolStripMenuItem,
            this.salveazaModificariToolStripMenuItem,
            this.inapoiToolStripMenuItem});
            this.menuStripAdminUI.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdminUI.Name = "menuStripAdminUI";
            this.menuStripAdminUI.Padding = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.menuStripAdminUI.Size = new System.Drawing.Size(1000, 40);
            this.menuStripAdminUI.TabIndex = 20;
            this.menuStripAdminUI.Text = "menuStrip1";
            // 
            // adaugaStudentToolStripMenuItem
            // 
            this.adaugaStudentToolStripMenuItem.Name = "adaugaStudentToolStripMenuItem";
            this.adaugaStudentToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.adaugaStudentToolStripMenuItem.Text = "Adauga Stud&ent";
            this.adaugaStudentToolStripMenuItem.Click += new System.EventHandler(this.adaugaStudentToolStripMenuItem_Click);
            // 
            // adaugaProfesorToolStripMenuItem
            // 
            this.adaugaProfesorToolStripMenuItem.Name = "adaugaProfesorToolStripMenuItem";
            this.adaugaProfesorToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.adaugaProfesorToolStripMenuItem.Text = "Adauga &Profesor";
            this.adaugaProfesorToolStripMenuItem.Click += new System.EventHandler(this.adaugaProfesorToolStripMenuItem_Click);
            // 
            // adaugaCursToolStripMenuItem
            // 
            this.adaugaCursToolStripMenuItem.Name = "adaugaCursToolStripMenuItem";
            this.adaugaCursToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.adaugaCursToolStripMenuItem.Text = "Adauga &Curs";
            this.adaugaCursToolStripMenuItem.Click += new System.EventHandler(this.adaugaCursToolStripMenuItem_Click);
            // 
            // salveazaModificariToolStripMenuItem
            // 
            this.salveazaModificariToolStripMenuItem.Name = "salveazaModificariToolStripMenuItem";
            this.salveazaModificariToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.salveazaModificariToolStripMenuItem.Text = "&Salveaza Modificari";
            // 
            // inapoiToolStripMenuItem
            // 
            this.inapoiToolStripMenuItem.Name = "inapoiToolStripMenuItem";
            this.inapoiToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.inapoiToolStripMenuItem.Text = "Inapoi";
            this.inapoiToolStripMenuItem.Click += new System.EventHandler(this.inapoiToolStripMenuItem_Click);
            // 
            // myDataControl1
            // 
            this.myDataControl1.BackColor = System.Drawing.SystemColors.Window;
            this.myDataControl1.Location = new System.Drawing.Point(12, 532);
            this.myDataControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.myDataControl1.Name = "myDataControl1";
            this.myDataControl1.Size = new System.Drawing.Size(364, 81);
            this.myDataControl1.TabIndex = 21;
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1000, 613);
            this.Controls.Add(this.myDataControl1);
            this.Controls.Add(this.panelAddProffesor);
            this.Controls.Add(this.panelAddCourse);
            this.Controls.Add(this.panelAddStudent);
            this.Controls.Add(this.menuStripAdminUI);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripAdminUI;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminUI";
            this.Text = "AdminUI";
            this.Load += new System.EventHandler(this.AdminUI_Load);
            this.panelAddStudent.ResumeLayout(false);
            this.panelAddStudent.PerformLayout();
            this.panelAddProffesor.ResumeLayout(false);
            this.panelAddProffesor.PerformLayout();
            this.panelAddCourse.ResumeLayout(false);
            this.panelAddCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStripAdminUI.ResumeLayout(false);
            this.menuStripAdminUI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelAddStudent;
        private System.Windows.Forms.Label labelAddStud;
        private System.Windows.Forms.Label labelSName;
        private System.Windows.Forms.Label labelSPName;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblGrupa;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.TextBox tbGrupa;
        private System.Windows.Forms.ComboBox cbSerie;
        private System.Windows.Forms.ComboBox cbAn;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.ComboBox cbSpecializare;
        private System.Windows.Forms.ComboBox cbFinantare;
        private System.Windows.Forms.Label lblSpecializare;
        private System.Windows.Forms.Label lblFinantare;
        private System.Windows.Forms.Button btnSubmitStudent;
        private System.Windows.Forms.Panel panelAddProffesor;
        private System.Windows.Forms.Button btnSubmitProf;
        private System.Windows.Forms.ComboBox cbCurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSexProf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrenumeProf;
        private System.Windows.Forms.TextBox tbNumeProf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelAddCourse;
        private System.Windows.Forms.Button btnSubmitCourse;
        private System.Windows.Forms.TextBox tbCredite;
        private System.Windows.Forms.TextBox tbDenumireCurs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAddCourseField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPondereSeminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbpondereExamen;
        private System.Windows.Forms.MenuStrip menuStripAdminUI;
        private System.Windows.Forms.ToolStripMenuItem adaugaStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaCursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaModificariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inapoiToolStripMenuItem;
        private System.Windows.Forms.Button btnDeleteCourse;
        private MyDataControl myDataControl1;
    }
}