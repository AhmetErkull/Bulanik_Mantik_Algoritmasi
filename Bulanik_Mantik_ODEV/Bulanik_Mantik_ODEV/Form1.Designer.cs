namespace Bulanik_Mantik_ODEV
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_isle = new System.Windows.Forms.Button();
            this.lbl_hassaslikkume = new System.Windows.Forms.Label();
            this.lbl_miktarkume = new System.Windows.Forms.Label();
            this.lbl_kirlilikkume = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_donushizi = new System.Windows.Forms.Label();
            this.lbl_sure = new System.Windows.Forms.Label();
            this.lnl_deterjanmiktari = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hassaslık:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miktar:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 141);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kirlilik";
            // 
            // btn_isle
            // 
            this.btn_isle.Location = new System.Drawing.Point(32, 181);
            this.btn_isle.Name = "btn_isle";
            this.btn_isle.Size = new System.Drawing.Size(150, 28);
            this.btn_isle.TabIndex = 3;
            this.btn_isle.Text = "İşle";
            this.btn_isle.UseVisualStyleBackColor = true;
            this.btn_isle.Click += new System.EventHandler(this.btn_isle_Click);
            // 
            // lbl_hassaslikkume
            // 
            this.lbl_hassaslikkume.AutoSize = true;
            this.lbl_hassaslikkume.Location = new System.Drawing.Point(272, 47);
            this.lbl_hassaslikkume.Name = "lbl_hassaslikkume";
            this.lbl_hassaslikkume.Size = new System.Drawing.Size(0, 13);
            this.lbl_hassaslikkume.TabIndex = 3;
            // 
            // lbl_miktarkume
            // 
            this.lbl_miktarkume.AutoSize = true;
            this.lbl_miktarkume.Location = new System.Drawing.Point(272, 95);
            this.lbl_miktarkume.Name = "lbl_miktarkume";
            this.lbl_miktarkume.Size = new System.Drawing.Size(0, 13);
            this.lbl_miktarkume.TabIndex = 3;
            // 
            // lbl_kirlilikkume
            // 
            this.lbl_kirlilikkume.AutoSize = true;
            this.lbl_kirlilikkume.Location = new System.Drawing.Point(272, 144);
            this.lbl_kirlilikkume.Name = "lbl_kirlilikkume";
            this.lbl_kirlilikkume.Size = new System.Drawing.Size(0, 13);
            this.lbl_kirlilikkume.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(372, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(712, 633);
            this.dataGridView1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 297);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 316);
            this.listBox1.TabIndex = 5;
            // 
            // lbl_donushizi
            // 
            this.lbl_donushizi.AutoSize = true;
            this.lbl_donushizi.Location = new System.Drawing.Point(19, 54);
            this.lbl_donushizi.Name = "lbl_donushizi";
            this.lbl_donushizi.Size = new System.Drawing.Size(0, 13);
            this.lbl_donushizi.TabIndex = 6;
            // 
            // lbl_sure
            // 
            this.lbl_sure.AutoSize = true;
            this.lbl_sure.Location = new System.Drawing.Point(19, 104);
            this.lbl_sure.Name = "lbl_sure";
            this.lbl_sure.Size = new System.Drawing.Size(0, 13);
            this.lbl_sure.TabIndex = 6;
            // 
            // lnl_deterjanmiktari
            // 
            this.lnl_deterjanmiktari.AutoSize = true;
            this.lnl_deterjanmiktari.Location = new System.Drawing.Point(21, 153);
            this.lnl_deterjanmiktari.Name = "lnl_deterjanmiktari";
            this.lnl_deterjanmiktari.Size = new System.Drawing.Size(0, 13);
            this.lnl_deterjanmiktari.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lnl_deterjanmiktari);
            this.groupBox1.Controls.Add(this.lbl_donushizi);
            this.groupBox1.Controls.Add(this.lbl_sure);
            this.groupBox1.Location = new System.Drawing.Point(202, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 177);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ağırlıklı Ortalamalar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Deterjan Miktarı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Süre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Dönüş Hızı:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(15, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mamdani";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 693);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_kirlilikkume);
            this.Controls.Add(this.lbl_miktarkume);
            this.Controls.Add(this.lbl_hassaslikkume);
            this.Controls.Add(this.btn_isle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Bulanık Mantık Ödevi 203311109 Ahmet Erkul";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_isle;
        private System.Windows.Forms.Label lbl_hassaslikkume;
        private System.Windows.Forms.Label lbl_miktarkume;
        private System.Windows.Forms.Label lbl_kirlilikkume;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_donushizi;
        private System.Windows.Forms.Label lbl_sure;
        private System.Windows.Forms.Label lnl_deterjanmiktari;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}

