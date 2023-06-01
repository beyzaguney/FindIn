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
    public partial class Ilan : DevExpress.XtraEditors.XtraForm
    {
        public Ilan()
        {
            InitializeComponent();
            Response rs = FormGiris.sql.SelectIslemi("select * from Kategoriler");
            cbKategori.DataSource = rs.tablo;
            cbKategori.DisplayMember = "KategoriAdi";
            cbKategori.ValueMember = "KategoriID";
            cbKategori.SelectedIndex = -1;
        }
        int isBoyut, isSure;
        void IlanOlustur()
        {
            Response res = FormGiris.sql.FizikselKomut(@"insert into Ilanlar(Baslik,Aciklama,Ucret,AktifMi,KullaniciID,KategoriID,IsBoyutuID,IsSuresiID,BolgeID)
                                                       values(@Baslik,@Aciklama,@Ucret,1,@KullaniciID,@KategoriID,@IsBoyutuID,@IsSuresiID,@BolgeID)",
                                                       new SqlParametresi("@Baslik", txtBaslik.Text),
                                                       new SqlParametresi("@Aciklama", txtAciklama.Text),
                                                       new SqlParametresi("@Ucret", txtUcret.Text),
                                                       new SqlParametresi("@KullaniciID", FormGiris.AktifKullaniciID),
                                                       new SqlParametresi("@KategoriID", (int)cbKategori.SelectedValue),
                                                       new SqlParametresi("@IsBoyutuID", isBoyut),
                                                       new SqlParametresi("@IsSuresiID", isSure),
                                                       new SqlParametresi("@BolgeID",FormAnaSayfa.bolge));
            if (!res.HataliMi)
            {
                MessageBox.Show("Ilan Oluşturuldu");
                Close();
            }
            else
            {
                MessageBox.Show(res.Mesaj, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                isBoyut = 3;
            else if (radioButton2.Checked)
                isBoyut = 2;
            else if (radioButton3.Checked)
                isBoyut = 1;
            else
            {
                MessageBox.Show("Lütfen iş boyutu seçin!");
                return;
            }

            if (radioButton4.Checked)
                isSure = 3;
            else if (radioButton5.Checked)
                isSure = 2;
            else if (radioButton6.Checked)
                isSure = 1;
            else
            {
                MessageBox.Show("Lütfen iş süresi seçin!");
                return;
            }

            if (int.Parse(txtUcret.Text) < 10)
            {
                MessageBox.Show("Ücret 10 dolardan az olamaz.");
                return;
            }
            IlanOlustur();
        }
    }
}