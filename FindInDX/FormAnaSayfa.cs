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
    public partial class FormAnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
            ProfilBilgileri();
            Response rs = FormGiris.sql.SelectIslemi("select * from Kategoriler");
            cbKategori.DisplayMember = "KategoriAdi";
            cbKategori.ValueMember = "KategoriID";
            cbKategori.DataSource = rs.tablo;
            cbKategori.SelectedIndex = -1;
        }
        public static string bolge;
        int ilanid;

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            if (FormGiris.uyeTipi == false)
            {
                pgIlanlar.PageVisible = false;
                IlanlarimListele();
                BasvuruListele();
            }
            else
            {
                pgIlanlarim.PageVisible = false;
                IlanListele();
            }
            
        }
        void ProfilBilgileri()
        {
            Response res = FormGiris.sql.SelectIslemi(@"select * from Kullanicilar k
                                                      left join KullaniciDetay kd on kd.KullaniciID=k.KullaniciID where k.KullaniciID=@ID",
                                                      new SqlParametresi("@ID", FormGiris.AktifKullaniciID));

            bolge = res.tablo.Rows[0]["BolgeID"].ToString();

            txtAd.Text = res.tablo.Rows[0]["Ad"].ToString();
            txtSoyad.Text = res.tablo.Rows[0]["Soyad"].ToString();
            txtBio.Text = res.tablo.Rows[0]["Biyografi"].ToString();
            Response ress = FormGiris.sql.SelectIslemi(@"select TamamlananIsSayisi from Degerlendirmeler d
                                                        left join KullaniciDetay kd on kd.KullaniciID=d.KullaniciID where kd.KullaniciID=@ID",
                                                       new SqlParametresi("@ID", FormGiris.AktifKullaniciID));
            if (!(ress.tablo.Rows.Count == 0))
            {
                lblTamIs.Text = ress.tablo.Rows[0]["TamamlananIsSayisi"].ToString();
            }
            else
                return;
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            Ilan il = new Ilan();
            il.ShowDialog();
            IlanlarimListele();
        }

        //işveren ilanları listeleme
        Response ilanlarim;
        void IlanlarimListele()
        {
            ilanlarim = FormGiris.sql.SelectIslemi(@"select i.IlanID,k.KategoriAdi,i.Baslik,i.Aciklama,ib.BoyutAdi,iss.SureAdi,i.Ucret,i.GoruntulemeSayisi,i.AktifMi from Ilanlar i
                                                        left join Kategoriler k on k.KategoriID = i.KategoriID
                                                        left join IsBoyutlari ib on ib.IsBoyutuID = i.IsBoyutuID
                                                        left join IsSureleri iss on iss.SureID = i.IsSuresiID where i.KullaniciID = @KullaniciID",
                                                     new SqlParametresi("@KullaniciID", FormGiris.AktifKullaniciID));
            dgvIlanlarim.DataSource = ilanlarim.tablo;
            gridView2.Columns["IlanID"].Visible = false;
        }


        //kategori farketmeksizin bütün ilanları listeleme
        void IlanListele()
        {

            Response res = FormGiris.sql.SelectIslemi(@"select i.IlanID,k.KategoriAdi,i.Baslik,i.Aciklama,ib.BoyutAdi, iss.SureAdi,i.Ucret from Ilanlar i
                                                        left join Kategoriler k on k.KategoriID = i.KategoriID
                                                        left join IsBoyutlari ib on ib.IsBoyutuID = i.IsBoyutuID
                                                        left join IsSureleri iss on iss.SureID = i.IsSuresiID where i.BolgeID=@BolgeID and i.AktifMi = 1",
                                                     new SqlParametresi("@BolgeID", bolge));
            if (res.HataliMi == true)
            {
                MessageBox.Show(res.Mesaj);
            }
            else
            {
                dgvIlanlar.DataSource = res.tablo;
                gridView1.Columns["IlanID"].Visible = false;
            }
        }


        //kategori filtresine göre ilan listeleme aşırı yüklemesi
        void IlanListele(int kategori)
        {
            Response res = FormGiris.sql.SelectIslemi(@"select i.IlanID,k.KategoriAdi,i.Baslik,i.Aciklama,ib.BoyutAdi, iss.SureAdi,i.Ucret from Ilanlar i
                                                        left join Kategoriler k on k.KategoriID = i.KategoriID
                                                        left join IsBoyutlari ib on ib.IsBoyutuID = i.IsBoyutuID
                                                        left join IsSureleri iss on iss.SureID = i.IsSuresiID where i.KategoriID = @KategoriID and i.BolgeID=@BolgeID and i.AktifMi = 1",
                                                     new SqlParametresi("@BolgeID", bolge),
                                                     new SqlParametresi("@KategoriID", kategori));
            if (res.HataliMi == true)
            {
                MessageBox.Show(res.Mesaj);
            }
            else
            {
                dgvIlanlar.DataSource = res.tablo;
                gridView1.Columns["IlanID"].Visible = false;
            }
        }
        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            int kat = Convert.ToInt32(cbKategori.SelectedValue);
            IlanListele(kat);

        }
        void BasvuruListele()
        {
            Response res = FormGiris.sql.SelectIslemi(@"select i.IlanID, i.Baslik, b.BasvuruMetni,b.BasvuranID, kd.Ad,kd.Soyad,k.EPosta from Basvurular b
                                                        left join Ilanlar i on b.IlanID=i.IlanID
                                                        left join Kullanicilar k on k.KullaniciID=b.BasvuranID
                                                        left join KullaniciDetay kd on kd.KullaniciID=k.KullaniciID where b.KabulDurumu is null and b.BasvuranID=k.KullaniciID and i.KullaniciID=@KullaniciID",
                                                       new SqlParametresi("@KullaniciID", FormGiris.AktifKullaniciID));
            dgvBasvurular.DataSource = res.tablo;
            gridView3.Columns["IlanID"].Visible = false;
            gridView3.Columns["BasvuranID"].Visible = false;
        }



        //aktif ilanı kaldırma/silme
        private void btnKaldır_Click(object sender, EventArgs e)
        {
            if (gridView2.GetFocusedRowCellValue("IlanID") == null)
            {
                MessageBox.Show("İlan seçmediniz.");
            }
            else
            {
                ilanid = (int)gridView2.GetFocusedRowCellValue("IlanID");
                Response res = FormGiris.sql.FizikselKomut("delete from Ilanlar where IlanID=@IlanID",
                                                            new SqlParametresi("@IlanID", ilanid));
                if ((int)ilanlarim.tablo.Rows[0]["AktifMi"] == 1)
                {
                    if (!res.HataliMi)
                    {
                        MessageBox.Show("İlan Kaldırılmıştır");
                    }
                    else
                    {
                        MessageBox.Show(res.Mesaj);
                    }
                }
                else
                    MessageBox.Show("Tamamlanan ilan kaldırılamaz.");
            }
        }

        //ilan tamamlandı ve pasif hale getirildi
        
        public static int csecilenilan,isecilenilan,basvuranid;//çalışanın seçtiği ilan, işverenin seçtiği ilan

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            basvuranid = (int)gridView3.GetFocusedRowCellValue("BasvuranID");
            isecilenilan = (int)gridView3.GetFocusedRowCellValue("IlanID");
            IlanBasvuru frm = new IlanBasvuru();
            frm.ShowDialog();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            csecilenilan = (int)gridView1.GetFocusedRowCellValue("IlanID");
            IlanBasvuru frm = new IlanBasvuru();
            frm.ShowDialog();

        }
    }
}
