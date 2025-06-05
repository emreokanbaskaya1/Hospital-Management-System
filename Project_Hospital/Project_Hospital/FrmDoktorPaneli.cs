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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            //Doktorları Datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select *  From Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1); // Fill the DataTable with data from the database
            dataGridView1.DataSource = dt1; // Bind the DataTable to the DataGridView

            //Branşları comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]); // Add each branch to the combobox
            }
            bgl.baglanti().Close(); // Close the database connection
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd, DoktorSoyad, DoktorBrans, DoktorTC, DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtAd.Text);
            komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", MskTC.Text);
            komut.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komut.ExecuteNonQuery(); // Execute the command to insert the new doctor
            bgl.baglanti().Close(); // Close the database connection
            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; // Get the index of the selected row
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString(); // Get the doctor's name
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString(); // Get the doctor's surname
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString(); // Get the doctor's branch
            MskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString(); // Get the doctor's TC number
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString(); // Get the doctor's password
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC = @p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text); // Set the parameter for the command
            komut.ExecuteNonQuery(); // Execute the command to delete the doctor
            bgl.baglanti().Close(); // Close the database connection
            MessageBox.Show("Doktor Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1, DoktorSoyad=@d2, DoktorBrans=@d3, DoktorSifre=@d5 where DoktorTC=@d4",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtAd.Text);
            komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", MskTC.Text);
            komut.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komut.ExecuteNonQuery(); // Execute the command to insert the new doctor
            bgl.baglanti().Close(); // Close the database connection
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
