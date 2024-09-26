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
    public partial class formkasiyertakip : Form
    {
        public formkasiyertakip()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Market.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void bilgiliyi()
        {

            listkasiyersatisi.Items.Clear();
            baglan.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglan;
            komut.CommandText = ("Select * From market3");
            OleDbDataReader okuyor = komut.ExecuteReader();
            while (okuyor.Read())
            {
                ListViewItem ekleme = new ListViewItem();
                ekleme.Text = okuyor["kasiyer_adi"].ToString();
                ekleme.SubItems.Add(okuyor["ürün"].ToString());
                ekleme.SubItems.Add(okuyor["katagori"].ToString());
                ekleme.SubItems.Add(okuyor["fiyat"].ToString());
                ekleme.SubItems.Add(okuyor["takvim"].ToString());
                listkasiyersatisi.Items.Add(ekleme);
            }
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                formanasayfa Form1 = new formanasayfa();
                Form1.Show();
                this.Hide();
            }
            catch { }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            bilgiliyi();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblkasiyerad.Text = listkasiyersatisi.SelectedItems[0].SubItems[0].Text.ToString();
                
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                decimal topla = 0;

                for (int sayi = 0; sayi <= listkasiyersatisi.Items.Count - 1; sayi++)
                {

                    decimal sayi1;

                    string sayi2;

                    sayi2 = listkasiyersatisi.Items[sayi].SubItems[3].Text;

                    sayi1 = decimal.Parse(sayi2);

                    topla = topla + sayi1;

                }

                lbltoplamsatis.Text = topla.ToString();
                MessageBox.Show("toplam sepet fiyatı  " + topla + " TL".ToString());
            }
            catch { MessageBox.Show("toplam bulunamadı"); }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listkasiyersatisi.Items.Clear();
                baglan.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = ("Select * From market3 where kasiyer_adi='" + lblkasiyerad.Text + "'");
                OleDbDataReader okuyor = komut.ExecuteReader();
                while (okuyor.Read())
                {
                    ListViewItem ekleme = new ListViewItem();
                    ekleme.Text = okuyor["kasiyer_adi"].ToString();
                    ekleme.SubItems.Add(okuyor["ürün"].ToString());
                    ekleme.SubItems.Add(okuyor["katagori"].ToString());
                    ekleme.SubItems.Add(okuyor["fiyat"].ToString());
                    ekleme.SubItems.Add(okuyor["takvim"].ToString());
                    listkasiyersatisi.Items.Add(ekleme);
                }
                baglan.Close();
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bilgiliyi();
        }
    }
}
