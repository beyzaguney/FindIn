﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FindInDX
{
    public partial class FormGiris : DevExpress.XtraEditors.XtraForm
    {
        public static SQLIslemleri sql;
        public static string AktifKullaniciID;
        public static bool uyeTipi;
       
        public FormGiris()
        {
            InitializeComponent();
            sql = new SQLIslemleri("BEYZA\\BEYZA", "FindIn");
            txtEposta.Text = "bb@gmail.com";
            txtSifre.Text = "1233";
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (!txtEposta.Text.Contains('@') || !txtEposta.Text.Contains('.'))
            {
                MessageBox.Show("Email Formatı Hatalı");
                return;
            }
            Response response = sql.SelectIslemi("select * from Kullanicilar k left join KullaniciDetay kd on k.KullaniciID=kd.KullaniciID where EPosta=@Eposta and Sifre=@Sifre",
                new SqlParametresi("@EPosta",txtEposta.Text),
                new SqlParametresi("@Sifre",txtSifre.Text));
            if (response.tablo.Rows.Count == 0)
            {
                MessageBox.Show("E-Posta ya da şifre yanlış", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AktifKullaniciID = (response.tablo.Rows[0]["KullaniciID"]).ToString();
            uyeTipi = (bool)response.tablo.Rows[0]["KullaniciTipi"];

            FormAnaSayfa home = new FormAnaSayfa();
            this.Hide();
            home.ShowDialog();
            this.Show();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
           
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            FormUyeOl frm = new FormUyeOl();
            frm.ShowDialog();
        }
    }
}
