namespace Centralizator_Situatii_Studenti
{
    partial class StudentGraphs
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbCurs = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCriteriu = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printeazaGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaCaImagineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbaCuloareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecteaza cursul:";
            // 
            // cbCurs
            // 
            this.cbCurs.FormattingEnabled = true;
            this.cbCurs.Location = new System.Drawing.Point(171, 17);
            this.cbCurs.Name = "cbCurs";
            this.cbCurs.Size = new System.Drawing.Size(279, 28);
            this.cbCurs.TabIndex = 1;
            this.cbCurs.SelectedIndexChanged += new System.EventHandler(this.cbCurs_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Location = new System.Drawing.Point(1, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 501);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Criteriu:";
            // 
            // cbCriteriu
            // 
            this.cbCriteriu.FormattingEnabled = true;
            this.cbCriteriu.Items.AddRange(new object[] {
            "Status Finalizare",
            "Inscrieri Curs vs Total Studenti",
            "Distributie Rating"});
            this.cbCriteriu.Location = new System.Drawing.Point(584, 17);
            this.cbCriteriu.Name = "cbCriteriu";
            this.cbCriteriu.Size = new System.Drawing.Size(270, 28);
            this.cbCriteriu.TabIndex = 4;
            this.cbCriteriu.SelectedIndexChanged += new System.EventHandler(this.cbCriteriu_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printeazaGraficToolStripMenuItem,
            this.salveazaCaImagineToolStripMenuItem,
            this.schimbaCuloareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 76);
            // 
            // printeazaGraficToolStripMenuItem
            // 
            this.printeazaGraficToolStripMenuItem.Name = "printeazaGraficToolStripMenuItem";
            this.printeazaGraficToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.printeazaGraficToolStripMenuItem.Text = "Printeaza grafic";
            this.printeazaGraficToolStripMenuItem.Click += new System.EventHandler(this.printeazaGraficToolStripMenuItem_Click);
            // 
            // salveazaCaImagineToolStripMenuItem
            // 
            this.salveazaCaImagineToolStripMenuItem.Name = "salveazaCaImagineToolStripMenuItem";
            this.salveazaCaImagineToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.salveazaCaImagineToolStripMenuItem.Text = "Salveaza ca imagine";
            this.salveazaCaImagineToolStripMenuItem.Click += new System.EventHandler(this.salveazaCaImagineToolStripMenuItem_Click);
            // 
            // schimbaCuloareToolStripMenuItem
            // 
            this.schimbaCuloareToolStripMenuItem.Name = "schimbaCuloareToolStripMenuItem";
            this.schimbaCuloareToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.schimbaCuloareToolStripMenuItem.Text = "Schimba culoare";
            this.schimbaCuloareToolStripMenuItem.Click += new System.EventHandler(this.schimbaCuloareToolStripMenuItem_Click);
            // 
            // StudentGraphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(888, 568);
            this.Controls.Add(this.cbCriteriu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbCurs);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StudentGraphs";
            this.Text = "StudentGraphs";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCurs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCriteriu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printeazaGraficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaCaImagineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareToolStripMenuItem;
    }
}