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
    public partial class MyDataControl : UserControl
    {
        public MyDataControl()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
    }
}
