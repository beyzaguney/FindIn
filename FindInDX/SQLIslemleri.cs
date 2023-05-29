using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FindInDX
{
    public class SQLIslemleri
    {
        static SqlConnection baglanti;
        public SQLIslemleri(string sunucu, string veritabaniAdi)
        {
            baglanti = new SqlConnection();
            string baglantiMetni = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=true;", sunucu, veritabaniAdi);
            baglanti.ConnectionString = baglantiMetni;

            try
            {
                baglanti.Open();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Baglanti Hatası\nInternet bağlantınız yok ya da sunucu bilgileriniz yanlış", ex);
            }
        }

        public Response SelectIslemi(string sorgu, params SqlParametresi[] parametreler)
        {
            Response response = new Response();
            try
            {
                SqlDataAdapter adaptor = new SqlDataAdapter();
                SqlCommand komut = new SqlCommand();
                komut.CommandText = sorgu;
                adaptor.SelectCommand = komut;
                adaptor.SelectCommand.Connection = baglanti;
                if (parametreler.Length > 0)
                    for (int i = 0; i < parametreler.Length; i++)
                        komut.Parameters.AddWithValue(parametreler[i].parametreAdi, parametreler[i].datasi);
                adaptor.Fill(response.tablo);
            }
            catch (Exception ex)
            {
                response.HataliMi = true;
                response.Mesaj = ex.Message;
                response.tablo = null;
            }
            return response;
        }

        public Response FizikselKomut(string sorgu, params SqlParametresi[] parametreler)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sorgu;
            for (int i = 0; i < parametreler.Length; i++)
                komut.Parameters.AddWithValue(parametreler[i].parametreAdi, parametreler[i].datasi);
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            Response response = new Response();
            try
            {
                baglanti.Open();
                int etkilenenSatir = komut.ExecuteNonQuery();
                baglanti.Close();
                response.Mesaj = string.Format("{0} satır etkilendi.", etkilenenSatir);
            }
            catch (Exception ex)
            {
                baglanti.Close();
                response.HataliMi = true;
                response.Mesaj = ex.Message;
            }
            return response;
        }

    }
    public class Response
    {
        public DataTable tablo;
        public bool HataliMi;
        public string Mesaj;

        public Response()
        {
            tablo = new DataTable();
            HataliMi = false;
            Mesaj = "";
        }
    }

    public class SqlParametresi
    {
        public string parametreAdi;
        public object datasi;
        public SqlParametresi(string parametreAdi, object datasi)
        {
            this.parametreAdi = parametreAdi;
            this.datasi = datasi;
        }
    }
}
