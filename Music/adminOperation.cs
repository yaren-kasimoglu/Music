using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Music
{
    public partial class adminOperation : Form
    {

        public adminOperation()
        {
            InitializeComponent();
        }
        private void adminOperation_Load(object sender, EventArgs e)
        {
            /* build.ToString();
             Listele_Ara("Select* from sarkilar");*/
        }

        /*   private void button2_Click(object sender, EventArgs e)
           {
               try
               {
                   MySqlConnection connection;
                   string cs = ("SERVER = localhost; DATABASE = kullanıcılar; UID = root; PWD = Yaren.7030*");
                   connection = new MySqlConnection(cs);

                   if (upload.Text.Length > 0 )
                   {
                       string FileName = upload.Text;

                       byte[] f = File.ReadAllBytes(upload.Text);

                     MySqlCommand selectcom = new MySqlCommand("insert into file (mmusic,[content]) values(@mmusic,@file))", connection);
                       MySqlDataReader myread;

                       connection.Open();
                       myread = selectcom.ExecuteReader();
                       while (myread.Read())
                       {
                       }

                       connection.Close();
                       MessageBox.Show("Data saved successfully");
                       upload.Text = "";
                   }
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.ToString());
               }
           }

           private void button1_Click(object sender, EventArgs e)
           {
               try
               {
                   OpenFileDialog openFileDialog1 = new OpenFileDialog();
                   openFileDialog1.Filter = "Audio files | *.mp3";

                   if (openFileDialog1.ShowDialog() == DialogResult.OK)
                   {
                       upload.Text = openFileDialog1.FileName;
                   }
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
           }*/



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection;
                string cs = ("SERVER = localhost; DATABASE = kullanıcılar; UID = root; PWD = Yaren.7030*");
                connection = new MySqlConnection(cs);

                if (upload.Text.Length > 0 &&
                    vName.Text.Length > 0 &&
                    vTel.Text.Length > 0 &&
                    tbposition.Text.Length > 0)
                {
                    string FileName = upload.Text;

                    byte[] f = File.ReadAllBytes(upload.Text);

                    MySqlCommand selectcom = new MySqlCommand("insert into songs(idmuzik,admuzik,link_muzik,tarihmuzik)values('" + vName.Text + "','" + tbposition.Text + "','" + vTel.Text + "','" + f + "')", connection);
                    MySqlDataReader myread;

                    connection.Open();
                    myread = selectcom.ExecuteReader();
                    while (myread.Read())
                    {
                    }

                    connection.Close();
                    MessageBox.Show("Data saved successfully");
                    vName.Text = "";
                    vTel.Text = "";
                    tbposition.Text = "";
                    upload.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Audio files | *.mp3";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    upload.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
