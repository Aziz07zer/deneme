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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\Market işletme\\AzizoMarket\\AzizoMarket\\bin\\DataBase\\Market.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void bilgili()
        {

            listView1.Items.Clear();
            baglan.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglan;
            komut.CommandText = ("Select * From market2");
            OleDbDataReader okuyor = komut.ExecuteReader();
            while (okuyor.Read())
            {
                ListViewItem ekleme = new ListViewItem();
                ekleme.Text = okuyor["ürün"].ToString();
                ekleme.SubItems.Add(okuyor["katagori"].ToString());
                ekleme.SubItems.Add(okuyor["fiyat"].ToString());
                ekleme.SubItems.Add(okuyor["takvim"].ToString());
                listView1.Items.Add(ekleme);
            }
            baglan.Close();
        }
        private void bilgi()
        {

            listView2.Items.Clear();
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
                listView2.Items.Add(ekleme);
            }
            baglan.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            bilgili();
            bilgi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                baglan.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = ("Select * From market1 where ürün='" + textBox2.Text + "'");
                OleDbDataReader okuyor = komut.ExecuteReader();
                while (okuyor.Read())
                {
                    ListViewItem ekleme = new ListViewItem();
                    ekleme.Text = okuyor["ürün"].ToString();
                    ekleme.SubItems.Add(okuyor["katagori"].ToString());
                    ekleme.SubItems.Add(okuyor["fiyat"].ToString());
                    ekleme.SubItems.Add(okuyor["takvim"].ToString());
                    listView1.Items.Add(ekleme);
                }
                baglan.Close();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                decimal topla = 0;

                for (int sayi = 0; sayi <= listView1.Items.Count - 1; sayi++)
                {

                    decimal sayi1;

                    string sayi2;

                    sayi2 = listView1.Items[sayi].SubItems[2].Text;

                    sayi1 = decimal.Parse(sayi2);

                    topla = topla + sayi1;

                }

                label1.Text = topla.ToString();
                MessageBox.Show("toplam sepet fiyatı  " + topla + " TL".ToString());
            }
            catch { MessageBox.Show("toplam bulunamadı"); }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = listView1.SelectedItems[0].SubItems[0].Text.ToString();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }
    }
}
