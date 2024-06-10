namespace Centralizator_Situatii_Studenti
{
    partial class StudentsGradesForm
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
            this.cbCurs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelGrades = new System.Windows.Forms.Panel();
            this.btnValidate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSeminar = new System.Windows.Forms.TextBox();
            this.tbExamen = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCurs
            // 
            this.cbCurs.FormattingEnabled = true;
            this.cbCurs.Location = new System.Drawing.Point(217, 83);
            this.cbCurs.Name = "cbCurs";
            this.cbCurs.Size = new System.Drawing.Size(257, 28);
            this.cbCurs.TabIndex = 0;
            this.cbCurs.SelectedIndexChanged += new System.EventHandler(this.cbCurs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Validare note studenti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecteaza cursul:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(47, 138);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(327, 315);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id Student";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nume Student";
            this.columnHeader2.Width = 220;
            // 
            // panelGrades
            // 
            this.panelGrades.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelGrades.Controls.Add(this.tbId);
            this.panelGrades.Controls.Add(this.tbExamen);
            this.panelGrades.Controls.Add(this.tbSeminar);
            this.panelGrades.Controls.Add(this.label5);
            this.panelGrades.Controls.Add(this.label4);
            this.panelGrades.Controls.Add(this.label3);
            this.panelGrades.Controls.Add(this.btnValidate);
            this.panelGrades.Location = new System.Drawing.Point(415, 138);
            this.panelGrades.Name = "panelGrades";
            this.panelGrades.Size = new System.Drawing.Size(344, 315);
            this.panelGrades.TabIndex = 4;
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.PowderBlue;
            this.btnValidate.Location = new System.Drawing.Point(206, 232);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(93, 46);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "Validare";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Id Student:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nota Seminar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nota Examen:";
            // 
            // tbSeminar
            // 
            this.tbSeminar.Location = new System.Drawing.Point(185, 95);
            this.tbSeminar.Name = "tbSeminar";
            this.tbSeminar.Size = new System.Drawing.Size(114, 28);
            this.tbSeminar.TabIndex = 5;
            this.tbSeminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbExamen_KeyPress);
            // 
            // tbExamen
            // 
            this.tbExamen.Location = new System.Drawing.Point(185, 160);
            this.tbExamen.Name = "tbExamen";
            this.tbExamen.Size = new System.Drawing.Size(114, 28);
            this.tbExamen.TabIndex = 6;
            this.tbExamen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbExamen_KeyPress);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(185, 40);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(114, 28);
            this.tbId.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // StudentsGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(864, 533);
            this.Controls.Add(this.panelGrades);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCurs);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StudentsGradesForm";
            this.Text = "StudentsGradesForm";
            this.panelGrades.ResumeLayout(false);
            this.panelGrades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panelGrades;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbExamen;
        private System.Windows.Forms.TextBox tbSeminar;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}