using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Hospital
{
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) { 
              FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.TC = MskTC.Text; //Doktorun TC'sini detay formuna aktar
                fr.Show();
                this.Hide(); //Giriş başarılıysa doktor detay formunu aç ve bu formu gizle
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MskTC.Clear();
                TxtSifre.Clear();
                MskTC.Focus(); //Hatalı girişte kullanıcıyı tekrar TC alanına yönlendir
            }
            bgl.baglanti().Close(); //Veritabanı bağlantısını kapat
        }
    }
}
