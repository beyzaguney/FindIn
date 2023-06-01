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
    public partial class IlanBasvuru : DevExpress.XtraEditors.XtraForm
    {
        public IlanBasvuru()
        {
            InitializeComponent();
        }

        private void IlanBasvuru_Load(object sender, EventArgs e)
        {
            if (FormGiris.uyeTipi == false)
            {
                GelenBasvuruDoldur();
                btnIleri.Text = "Kabul Et";
            }
            else
            {
                YapilanBasvuruDoldur();
                btnReddet.Visible = false;
            }
        }
        void YapilanBasvuruDoldur()
        {
            Response res = FormGiris.sql.SelectIslemi("select Baslik from Ilanlar where IlanID=@IlanID", 
                                                    new SqlParametresi("@IlanID",FormAnaSayfa.csecilenilan));
            txtBaslik.Text = res.tablo.Rows[0]["Baslik"].ToString();
            txtBaslik.ReadOnly = true;

        }
        void GelenBasvuruDoldur()
        {
            Response res = FormGiris.sql.SelectIslemi(@"select i.Baslik, b.BasvuruMetni from Ilanlar i
                                                      left join Basvurular b on b.IlanID=i.IlanID where i.IlanID=@IlanID",
                                                      new SqlParametresi("@IlanID", FormAnaSayfa.isecilenilan));
            txtBaslik.Text = res.tablo.Rows[0]["Baslik"].ToString();
            txtMetin.Text = res.tablo.Rows[0]["BasvuruMetni"].ToString();
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if(btnIleri.Text=="Başvur")
            {
                Response res = FormGiris.sql.FizikselKomut(@"insert into Basvurular(IlanID,BasvuranID,BasvuruMetni) 
                                                           values(@IlanID,@BasvuranID,@BasvuruMetni)",
                                                            new SqlParametresi("@IlanID", FormAnaSayfa.csecilenilan),
                                                            new SqlParametresi("@BasvuranID", FormGiris.AktifKullaniciID),
                                                            new SqlParametresi("@BasvuruMetni", txtMetin.Text));
                if (!res.HataliMi)
                {
                    MessageBox.Show("Başvurunuz yapıldı");
                    Close();
                }
                else
                    MessageBox.Show(res.Mesaj);

            }
            else
            {
                Response r = FormGiris.sql.FizikselKomut(@"update Ilanlar set AktifMi=0 where IlanID=@IlanID",
                                                         new SqlParametresi("@IlanID", FormAnaSayfa.isecilenilan));
                Response res = FormGiris.sql.FizikselKomut(@"update Basvurular set KabulDurumu=1 where IlanID=@IlanID and BasvuranID=@Basvuran",
                                                         new SqlParametresi("@IlanID", FormAnaSayfa.isecilenilan),
                                                         new SqlParametresi("@Basvuran",FormAnaSayfa.basvuranid));
                if (!r.HataliMi)
                {
                    MessageBox.Show("Başvuruyu kabul ettiniz");
                    Response re = FormGiris.sql.FizikselKomut(@"update KullaniciDetay set TamamlananIsSayisi=TamamlananIsSayisi+1 where KullaniciID=@KullaniciID",
                                                            new SqlParametresi("@KullaniciID", FormGiris.AktifKullaniciID));
                    Close();
                }
                else
                    MessageBox.Show(r.Mesaj);
            }
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            Response res = FormGiris.sql.FizikselKomut(@"update Basvurular set KabulDurumu=0 where IlanID=@IlanID",
                                                     new SqlParametresi("@IlanID", FormAnaSayfa.isecilenilan));

        }
    }
}