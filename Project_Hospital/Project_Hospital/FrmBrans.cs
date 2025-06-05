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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi(); // Create an instance of the database connection class
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti()); // Create a data adapter to fetch data from the database
            da.Fill(dt);
            dataGridView1.DataSource = dt; // Bind the DataTable to the DataGridView to display the branches


        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1",TxtBrans.Text);
            komut.ExecuteNonQuery(); // Execute the command to insert a new branch
            bgl.baglanti().Close(); // Close the database connection
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show a message box to inform the user that the branch has been added
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; // Get the index of the selected row
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString(); // Get the branch ID from the selected row
            TxtBrans.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString(); // Get the branch name from the selected row
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand ("Delete From Tbl_Branslar where Bransid=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", Txtid.Text); // Use the branch ID to delete the specific branch
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Show a message box to inform the user that the branch has been deleted
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Branslar set BransAd=@b1 where Bransid=@b2", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", TxtBrans.Text); // Set the new branch name
            komut.Parameters.AddWithValue("@b2", Txtid.Text); // Set the branch ID for the update
            komut.ExecuteNonQuery();
            bgl.baglanti().Close(); // Close the database connection
            MessageBox.Show("Branş Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show a message box to inform the user that the branch has been updated

        }
    }
}
