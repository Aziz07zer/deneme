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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\Market işletme\\AzizoMarket\\AzizoMarket\\bin\\DataBase\\Market.mdb");
        OleDbCommand komut = new OleDbCommand();
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
        private void bilgili()
        {

            listView2.Items.Clear();
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
                listView2.Items.Add(ekleme);
            }
            baglan.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bilgi();
            bilgili();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                OleDbCommand komutlar = new OleDbCommand("insert into proje(ürün,katagori,fiyat,stok)values('" + textBox4.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox4.Text + "','" + textBox4.Text + "')", baglan);
                komutlar.ExecuteNonQuery();
                baglan.Close();
                bilgi();
          
                MessageBox.Show(komutlar.ToString());
            }
            catch
            {
                MessageBox.Show("başka ürün adı giriniz!!!");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text.ToString();
                textBox5.Text = listView1.SelectedItems[0].SubItems[2].Text.ToString();
                textBox2.Text = listView1.SelectedItems[0].SubItems[3].Text.ToString();
                textBox6.Text = listView1.SelectedItems[0].SubItems[1].Text.ToString();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                label2.Text = (Convert.ToInt16(textBox5.Text) * Convert.ToInt16(textBox4.Text)).ToString();
                textBox7.Text = (Convert.ToInt16(textBox5.Text) * Convert.ToInt16(textBox4.Text)).ToString();
                textBox3.Text = (Convert.ToInt16(textBox2.Text) - Convert.ToInt16(textBox4.Text)).ToString();
                komut.Connection = baglan;
                komut.CommandText = "update market1 set stok='" + textBox3.Text + "' where ürün='" + textBox1.Text + "'";
                komut.ExecuteNonQuery();
                baglan.Close();
                bilgi();
                komut.Connection = baglan;
                baglan.Close();
                MessageBox.Show("toplam fiyat " + textBox7.Text + " TL".ToString());
            }
            catch
            {
              
            }
         
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                OleDbCommand komut = new OleDbCommand("insert into market2 (ürün,katagori,fiyat,takvim) values ('" + textBox1.Text.ToString() + "', '" + textBox6.Text.ToString() + "', '" + textBox7.Text.ToString() + "', '" + dateTimePicker1.Value.ToString() + "')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                textBox4.Clear();
                bilgi();
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
         
            

          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listView2.Items.Clear();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
