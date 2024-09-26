using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AzizoMarket
{
    public partial class Form1 : Form
    {
        private OleDbConnection con;
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

       
      

        private void btnisci_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = textBox1.Text;
                string sifre = textBox2.Text;
                con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\Market işletme\\AzizoMarket\\AzizoMarket\\bin\\DataBase\\Market.mdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM market where ad='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Form2 Form2 = new Form2();
                    Form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                }

                con.Close();
            }
            catch 
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
