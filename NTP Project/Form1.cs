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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

                
        }
        static string connectstr = "Data Source=BEKOO;Initial Catalog=ntb_ogrenciler;Integrated Security=True";
        SqlConnection connect = new SqlConnection(connectstr);

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataReader sqlreader;

                    connect.Open();


                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = connect;
                                cmd.CommandText = "select * from ogrenci_info";
                                sqlreader = cmd.ExecuteReader();


                       while(sqlreader.Read())
                       {
                         students_combobox.Items.Add(sqlreader[1].ToString());
                       }

                  connect.Close();

        }

        private void checking_button_Click(object sender, EventArgs e)
        {
            try
            {
                        connect.Open();


                             SqlCommand cmd = new SqlCommand("select * from ogrenci_info where ogrenci Like'" + students_combobox.Text + "'", connect);
                             SqlDataReader sqlreader = cmd.ExecuteReader();

                        while(sqlreader.Read())
                        {
                                name_label.Text = (sqlreader["ogrenci"] + " öğrencinin notları:");
                             note1_listbox.Items.Add(sqlreader["not1"]);
                             note2_listbox.Items.Add(sqlreader["not2"]);
                             note3_listbox.Items.Add(sqlreader["not3"]);
                        }
            }
            catch(Exception error)
            {
                MessageBox.Show("Yaptığınız işlemde bir hata oluştu. Hata Nedeni" + error, "İşlem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void added_button_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void name_label_Click(object sender, EventArgs e)
        {

        }
    }
}
