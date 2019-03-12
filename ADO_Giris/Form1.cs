using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Tek bir dataset kullanarak iki tabloyu doldurabiliyoruz.
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        private DataTable dt;
        SqlDataAdapter adp ;
        private DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFillProduct_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Contains("Products"))
            {
                ds.Tables.Remove("Products");

            }
            adp = new SqlDataAdapter("Select * from Products", con);
            dt = new DataTable("Products");
            adp.Fill(dt);
            ds.Tables.Add(dt);
            MessageBox.Show("Alınan veriler,Ürünler Tablosuna Eklendi");
        }

        private void btnFillCategory_Click(object sender, EventArgs e)
        {

            if (ds.Tables.Contains("Categories"))
            {
                ds.Tables.Remove("Categories");

            }
            adp = new SqlDataAdapter("Select * from Categories", con);
            dt = new DataTable("Categories");
            adp.Fill(dt);
            ds.Tables.Add(dt);
            MessageBox.Show("Alınan veriler,Kategoriler Tablosuna Eklendi");
        }

        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables["Products"];
        }

        private void btnGetCategory_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables["Categories"];
        }
    }
}
