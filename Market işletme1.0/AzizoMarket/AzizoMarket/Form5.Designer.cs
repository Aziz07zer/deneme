namespace AzizoMarket
{
    partial class formkasiyertakip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblkasiyerad = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listkasiyersatisi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbltoplamsatis = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "ÇALIŞAN SATIŞLARI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÇALIŞAN\r\nADI:";
            // 
            // lblkasiyerad
            // 
            this.lblkasiyerad.AutoSize = true;
            this.lblkasiyerad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkasiyerad.Location = new System.Drawing.Point(72, 46);
            this.lblkasiyerad.Name = "lblkasiyerad";
            this.lblkasiyerad.Size = new System.Drawing.Size(89, 24);
            this.lblkasiyerad.TabIndex = 3;
            this.lblkasiyerad.Text = "ÇALIŞAN";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "giriş sayfası";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listkasiyersatisi
            // 
            this.listkasiyersatisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.listkasiyersatisi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listkasiyersatisi.ForeColor = System.Drawing.Color.Yellow;
            this.listkasiyersatisi.Location = new System.Drawing.Point(230, 12);
            this.listkasiyersatisi.Name = "listkasiyersatisi";
            this.listkasiyersatisi.Size = new System.Drawing.Size(695, 482);
            this.listkasiyersatisi.TabIndex = 5;
            this.listkasiyersatisi.UseCompatibleStateImageBehavior = false;
            this.listkasiyersatisi.View = System.Windows.Forms.View.Details;
            this.listkasiyersatisi.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "kasiyer adı";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ürün";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "kategori";
            this.columnHeader3.Width = 134;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "fiyat";
            this.columnHeader4.Width = 148;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "takvim";
            this.columnHeader5.Width = 199;
            // 
            // lbltoplamsatis
            // 
            this.lbltoplamsatis.AutoSize = true;
            this.lbltoplamsatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoplamsatis.Location = new System.Drawing.Point(9, 253);
            this.lbltoplamsatis.Name = "lbltoplamsatis";
            this.lbltoplamsatis.Size = new System.Drawing.Size(219, 31);
            this.lbltoplamsatis.TabIndex = 6;
            this.lbltoplamsatis.Text = "TOPLAM SATIŞ:";
            this.lbltoplamsatis.Click += new System.EventHandler(this.label3_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(12, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 97);
            this.button3.TabIndex = 7;
            this.button3.Text = "KASİYER\r\nSATIŞLARI";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(170, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 51);
            this.button4.TabIndex = 8;
            this.button4.Text = "tablo yenile";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // formkasiyertakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(937, 506);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbltoplamsatis);
            this.Controls.Add(this.listkasiyersatisi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblkasiyerad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "formkasiyertakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KASİYER TAKİP";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblkasiyerad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listkasiyersatisi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lbltoplamsatis;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}