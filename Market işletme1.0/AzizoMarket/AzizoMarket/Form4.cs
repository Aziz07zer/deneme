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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\Market işletme\\AzizoMarket\\AzizoMarket\\bin\\DataBase\\Market.mdb");
        OleDbCommand komut = new OleDbCommand();

        private void Form4_Load(object sender, EventArgs e)
        {
            bilgi();
        }
        private void bilgi()
        {

            listView1.Items.Clear();
            baglan.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglan;
            komut.CommandText = ("Select * From market1");
            OleDbDataReader okuyor = komut.ExecuteReader();
            while (okuyor.Read())
            {
                ListViewItem ekleme = new ListViewItem();
                ekleme.Text = okuyor["ürün"].ToString();
                ekleme.SubItems.Add(okuyor["katagori"].ToString());
                ekleme.SubItems.Add(okuyor["fiyat"].ToString());
                ekleme.SubItems.Add(okuyor["stok"].ToString());
                listView1.Items.Add(ekleme);
            }
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Enabled = (true);
                textBox2.Enabled = (true);
                textBox3.Enabled = (true);
                baglan.Open();
                OleDbCommand komutlar = new OleDbCommand("insert into market1(ürün,katagori,fiyat,stok)values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text + "','" + textBox4.Text + "')", baglan);
                komutlar.ExecuteNonQuery();
                baglan.Close();
                bilgi();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                
            }
            catch
            {
                MessageBox.Show("başka ürün adı giriniz!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                textBox1.Enabled = (true);
                textBox2.Enabled = (true);
                textBox3.Enabled = (true);

                OleDbCommand komut = new OleDbCommand();
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "delete from market1 where ürün = '" + textBox1.Text + "' ";
                komut.ExecuteNonQuery();
                baglan.Close();
                bilgi();
            }
            catch
            {


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled=(false);
            textBox2.Enabled = (false);
            textBox3.Enabled = (false);

            try
            {
                OleDbCommand komut = new OleDbCommand();
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "update market set katagori='" + textBox2.Text + "',fiyat='" + textBox3.Text + "',stok='" + textBox4.Text + "' where ürün='" + textBox1.Text + "'";
                komut.ExecuteNonQuery();
                baglan.Close();
                bilgi();
                MessageBox.Show(komut.ToString());

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("!!!");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text.ToString();
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text.ToString();
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text.ToString();
                textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text.ToString();
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }
    }
}
