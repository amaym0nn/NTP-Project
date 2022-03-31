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

namespace NTP_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string connectstr = "Data Source=BEKOO;Initial Catalog=ntb_ogrenciler;Integrated Security=True";
        SqlConnection connect = new SqlConnection(connectstr);

        private void button1_Click(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {

                connect.Open();


                string register = "insert into ogrenci_info (ogrenci,not1,not2,not3) values(@ogrenci,@not1,@not2,@not3)";

                SqlCommand cmd = new SqlCommand(register, connect);

                cmd.Parameters.AddWithValue("@ogrenci", student_name_textbox.Text);

                cmd.Parameters.AddWithValue("@not1", note1_textbox.Text);

                cmd.Parameters.AddWithValue("@not2", note2_textbox.Text);

                cmd.Parameters.AddWithValue("@not3", note3_textbox.Text);

                cmd.ExecuteNonQuery();


                connect.Close();

               DialogResult qstn =  MessageBox.Show("Öğrenci Notu Eklendi! Kontrol Panele Dönmek İster misiniz?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (qstn == DialogResult.Yes)
                    {
                         Form1 frm1 = new Form1();
                         frm1.Show();
                    }
            }
        }
    }
}
