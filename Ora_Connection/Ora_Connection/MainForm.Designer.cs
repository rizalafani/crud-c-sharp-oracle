/*
 * Created by SharpDevelop.
 * User: FaiQ
 * Date: 30/07/2013
 * Time: 6:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ora_Connection
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_simpan = new System.Windows.Forms.Button();
			this.btn_cari = new System.Windows.Forms.Button();
			this.btn_ubah = new System.Windows.Forms.Button();
			this.btn_hapus = new System.Windows.Forms.Button();
			this.btn_bersih = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(25, 122);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(475, 155);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "No Induk";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(104, 15);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(72, 20);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(104, 41);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(183, 20);
			this.textBox2.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(46, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nama";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(104, 67);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(243, 20);
			this.textBox3.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(41, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Alamat";
			// 
			// btn_simpan
			// 
			this.btn_simpan.Location = new System.Drawing.Point(101, 93);
			this.btn_simpan.Name = "btn_simpan";
			this.btn_simpan.Size = new System.Drawing.Size(75, 23);
			this.btn_simpan.TabIndex = 7;
			this.btn_simpan.Text = "Simpan";
			this.btn_simpan.UseVisualStyleBackColor = true;
			this.btn_simpan.Click += new System.EventHandler(this.Btn_simpanClick);
			// 
			// btn_cari
			// 
			this.btn_cari.Location = new System.Drawing.Point(182, 12);
			this.btn_cari.Name = "btn_cari";
			this.btn_cari.Size = new System.Drawing.Size(75, 23);
			this.btn_cari.TabIndex = 8;
			this.btn_cari.Text = "Cari";
			this.btn_cari.UseVisualStyleBackColor = true;
			this.btn_cari.Click += new System.EventHandler(this.Btn_cariClick);
			// 
			// btn_ubah
			// 
			this.btn_ubah.Location = new System.Drawing.Point(181, 93);
			this.btn_ubah.Name = "btn_ubah";
			this.btn_ubah.Size = new System.Drawing.Size(75, 23);
			this.btn_ubah.TabIndex = 9;
			this.btn_ubah.Text = "Ubah";
			this.btn_ubah.UseVisualStyleBackColor = true;
			this.btn_ubah.Click += new System.EventHandler(this.Btn_ubahClick);
			// 
			// btn_hapus
			// 
			this.btn_hapus.Location = new System.Drawing.Point(262, 93);
			this.btn_hapus.Name = "btn_hapus";
			this.btn_hapus.Size = new System.Drawing.Size(75, 23);
			this.btn_hapus.TabIndex = 10;
			this.btn_hapus.Text = "Hapus";
			this.btn_hapus.UseVisualStyleBackColor = true;
			this.btn_hapus.Click += new System.EventHandler(this.Btn_hapusClick);
			// 
			// btn_bersih
			// 
			this.btn_bersih.Location = new System.Drawing.Point(343, 93);
			this.btn_bersih.Name = "btn_bersih";
			this.btn_bersih.Size = new System.Drawing.Size(75, 23);
			this.btn_bersih.TabIndex = 11;
			this.btn_bersih.Text = "Bersih";
			this.btn_bersih.UseVisualStyleBackColor = true;
			this.btn_bersih.Click += new System.EventHandler(this.Btn_bersihClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 302);
			this.Controls.Add(this.btn_bersih);
			this.Controls.Add(this.btn_hapus);
			this.Controls.Add(this.btn_ubah);
			this.Controls.Add(this.btn_cari);
			this.Controls.Add(this.btn_simpan);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ora_Connection";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btn_bersih;
		private System.Windows.Forms.Button btn_hapus;
		private System.Windows.Forms.Button btn_ubah;
		private System.Windows.Forms.Button btn_cari;
		private System.Windows.Forms.Button btn_simpan;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
