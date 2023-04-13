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
    public partial class FormDogrulama : DevExpress.XtraEditors.XtraForm
    {
        public FormDogrulama()
        {
            InitializeComponent();
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            FormAnaSayfa frm = new FormAnaSayfa();
            frm.ShowDialog();
        }
    }
}