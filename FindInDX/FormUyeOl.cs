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
            Response cvp = FormGiris.sql.SelectIslemi("select * from Bolgeler");
            cbBolge.DataSource = cvp.tablo;
            cbBolge.DisplayMember = "BolgeAdi";
            cbBolge.ValueMember = "BolgeID";
            cbBolge.SelectedIndex = -1;
            
        }
        int uyeTipi,sayac=0;
        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkButton2.BackColor = Color.Orange;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 1)
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
                if (checkButton1.Checked == true)
                    uyeTipi = 0;
                else
                    uyeTipi = 1;
            }
            else
            {
                if (!txtAd.Text.Contains('@') || !txtAd.Text.Contains('.'))
                {
                    MessageBox.Show("Email Formatı Hatalı");
                    return;
                }
                else
                {
                    string sorguu = "select * from Kullanicilar where EPosta=@EPosta";
                    SqlParametresi parametre = new SqlParametresi("@EPosta", txtEposta.Text.ToString());
                    Response res = FormGiris.sql.SelectIslemi(sorguu, parametre);
                    if (res.tablo.Rows.Count == 0)
                    {
                        string sorgu = "exec sp_KullaniciEkle @Ad,@Soyad,@Eposta,@Sifre,@KullaniciTipi,@Biyografi,@BolgeID";

                        SqlParametresi[] parametreler =
                        {
                            new SqlParametresi("@Ad", txtAd.Text),
                            new SqlParametresi("@Soyad",txtSoyad.Text),
                            new SqlParametresi("@Eposta",txtEposta.Text),
                            new SqlParametresi("@Sifre",txtSifre.Text),
                            new SqlParametresi("@KullaniciTipi",uyeTipi),
                            new SqlParametresi("@Biyografi",txtBio.Text),
                            new SqlParametresi("@BolgeID",cbBolge.SelectedValue)
                        };
                        Response response = FormGiris.sql.FizikselKomut(sorgu, parametreler);
                        if(!response.HataliMi)
                        {
                            MessageBox.Show("Kayıt Eklendi");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(response.Mesaj, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu E-Posta adresine sahip bir kullanıcı zaten var!");
                    }
                }
            }
        }
    }
}