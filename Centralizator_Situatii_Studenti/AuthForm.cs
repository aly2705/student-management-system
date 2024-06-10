using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centralizator_Situatii_Studenti
{
    public partial class AuthForm : Form
    {
        Centralizator centralizator;
        
        public AuthForm(Centralizator centralizator, CentralForm.ClosedEventHandler handler)
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(handler);

            this.centralizator = centralizator;

            toolTip1.SetToolTip(labelAuth, "Coduri de testare roluri utilizator: profesor-P1002, student-S1005, admin-A1001");
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            if (tbAuthCod.Text == "") errorProvider1.SetError(tbAuthCod, "Introduceti codul!");
            else
                try
                {
                    errorProvider1.Clear();
                    centralizator.loginUtilizator(tbAuthCod.Text);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }


    }
}
