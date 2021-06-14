using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace Music
{
    public partial class UserCont1 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public UserCont1()
        {
            InitializeComponent();
            con = new MySqlConnection("SERVER = localhost; DATABASE = kullanıcılar; UID = root; PWD = Yaren.7030*");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string sifre = textBox2.Text;

            cmd = new MySqlCommand();
            con.Open();

            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM normaluser where User_Name='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                fMusic music = new fMusic();
                music.Show();
            }
            else
            {
                MessageBox.Show("Incorrect operation, Please Check Your UserName or Password");
            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox3.Text;
            string sifre = textBox4.Text;

            cmd = new MySqlCommand();
            con.Open();

            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM premiumuser where User_Name='" + textBox3.Text + "' AND Password='" + textBox4.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Congratulations Your Payment is Successful ");
                fMusic music = new fMusic();
                music.Show();
            }
            else
            {
                MessageBox.Show("Incorrect operation, Please Check Your UserName or Password");
            }
            con.Close();

        }
        private void UserCont1_Load(object sender, EventArgs e)
        {


        }

        private void adminbutton_Click(object sender, EventArgs e)
        {


             adminOperation aO = new adminOperation();


            if (textBox5.Text == "admin" && textBox6.Text == "0000")
            {
                MessageBox.Show("Admin Succesfull! ");

                aO.Show();
            }
            else
            {
                MessageBox.Show("Incorrect admin operation, Please Check Your UserName or Password");

            }
        }
    }
}


