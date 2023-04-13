using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindInDX
{
    public partial class FormUyeOl : DevExpress.XtraEditors.XtraForm
    {
        public FormUyeOl()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkButton2.BackColor = Color.Orange;
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            labelControl1.Visible = false;
            checkButton1.Visible = false;
            checkButton1.Enabled = false;
            checkButton2.Visible = false;
            checkButton2.Enabled = false;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            groupBox5.Visible = true;
        }
    }
}