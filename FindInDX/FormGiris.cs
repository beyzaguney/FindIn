using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FindInDX
{
    public partial class FormGiris : DevExpress.XtraEditors.XtraForm
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            FormUyeOl frm = new FormUyeOl();
            frm.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            FormAnaSayfa frm = new FormAnaSayfa();
            frm.ShowDialog();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
        }
    }
}
