/*
 * Created by SharpDevelop.
 * User: FaiQ
 * Date: 30/07/2013
 * Time: 6:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Ora_Connection
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		private DataSet ds;
		
		void MainFormLoad(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox1.Enabled = true;
			btn_simpan.Enabled = true;
			btn_cari.Enabled = true;
			btn_ubah.Enabled = false;
			btn_hapus.Enabled = false;
			btn_bersih.Enabled = false;
			textBox1.Focus();
			
			ds = Connection.GetInstance().GetMahasiswa();
			setTabel(ds);
		}
		
		void Btn_cariClick(object sender, EventArgs e)
		{
			if(textBox1.Text != ""){
				ds = Connection.GetInstance().GetMahasiswa("where nim = '"+textBox1.Text+"'");
				if(ds.Tables[0].Rows.Count > 0){
					foreach(DataRow row in ds.Tables[0].Rows){
						textBox1.Text = row["nim"].ToString();
						textBox2.Text = row["nama"].ToString();
						textBox3.Text = row["alamat"].ToString();
					}
					setTabel(ds);
					textBox1.Enabled = false;
					btn_simpan.Enabled = false;
					btn_cari.Enabled = false;
					btn_ubah.Enabled = true;
					btn_hapus.Enabled = true;
					btn_bersih.Enabled = true;
				}else{
					MessageBox.Show("Data yang anda cari tidak ada !","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
			}else{
				MessageBox.Show("Masukkan no induk dulu !","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}
		
		void Btn_bersihClick(object sender, EventArgs e)
		{
			MainFormLoad(null,null);
		}
		
		void Btn_simpanClick(object sender, EventArgs e)
		{
			if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != ""){
				if(Connection.GetInstance().InsertMahasiswa(textBox1.Text,textBox2.Text,textBox3.Text) == 1){
					MainFormLoad(null,null);
					MessageBox.Show("Insert Data Berhasil !","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}else{
					MessageBox.Show("Insert Data Gagal !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}else{
				MessageBox.Show("Input belum lengkap !","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}
		
		void Btn_hapusClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("Yakin hapus data ini ?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes){
				if(Connection.GetInstance().DeleteMahasiswa("where nim = '"+textBox1.Text+"'") == 1){
					MainFormLoad(null,null);
					MessageBox.Show("Hapus Data Berhasil !","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}else{
					MessageBox.Show("Hapus Data Gagal !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
		}
		
		void Btn_ubahClick(object sender, EventArgs e)
		{
			if(Connection.GetInstance().UpdateMahasiswa(textBox1.Text,textBox2.Text,textBox3.Text) == 1){
				MainFormLoad(null,null);
				MessageBox.Show("Ubah Data Berhasil !","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}else{
				MessageBox.Show("Ubah Data Gagal !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		private void setTabel(DataSet ds){
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.Columns[0].HeaderText = "No. Induk";
			dataGridView1.Columns[0].Width = 70;
			dataGridView1.Columns[1].HeaderText = "Nama Mahasiswa";
			dataGridView1.Columns[1].Width = 200;
			dataGridView1.Columns[2].HeaderText = "Alamat";
			dataGridView1.Columns[2].Width = 160;
		}
	}
}
