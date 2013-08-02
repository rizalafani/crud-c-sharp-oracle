/*
 * Created by SharpDevelop.
 * User: FaiQ
 * Date: 30/07/2013
 * Time: 6:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using Oracle.DataAccess.Client;

namespace Ora_Connection
{
	public class Connection
	{
		public Connection()
		{
			conn_string = "User ID = Rizal; Password = admin; Data Source = XE;";
			conn = new OracleConnection(conn_string);
		}
		
		private string conn_string,stat;
		private OracleConnection conn;
		private OracleCommand cmd;
		private OracleDataAdapter adapter;
		private DataSet ds;
		private int response;
		
		/* using singleton pattern for create instance object */
		public static Connection obj = null;
		public static Connection GetInstance(){
			if(obj == null){
				obj = new Connection();
			}
			return obj;
		}
		/* end singleton pattern */
		
		private DataSet GetData(string query){
			ds = new DataSet();
			conn.Open();
			cmd = new OracleCommand(query,conn);
			adapter = new OracleDataAdapter(cmd);
			cmd.ExecuteNonQuery();
			adapter.Fill(ds);
			conn.Close();
			return ds;
		}
		
		private int ManipulasiData(string query){
			ds = new DataSet();
			conn.Open();
			cmd = new OracleCommand(query,conn);
			adapter = new OracleDataAdapter(cmd);
			response = cmd.ExecuteNonQuery();
			conn.Close();
			return response;
		}
		
		public DataSet GetMahasiswa(){
			stat = "select * from mahasiswa";
			return GetData(stat);
		}
		
		public DataSet GetMahasiswa(string _where){
			stat = "select * from mahasiswa "+_where;
			return GetData(stat);
		}
		
		public int DeleteMahasiswa(string _where){
			stat = "delete from mahasiswa "+_where;
			return ManipulasiData(stat);
		}
		
		public int InsertMahasiswa(string nim,string nama,string alamat){
			stat = "insert into mahasiswa (nim,nama,alamat) values ('"+nim+"','"+nama+"','"+alamat+"')";
			return ManipulasiData(stat);
		}
		
		public int UpdateMahasiswa(string nim,string nama,string alamat){
			stat = "update mahasiswa set nama = '"+nama+"', alamat = '"+alamat+"' where nim = '"+nim+"'";
			return ManipulasiData(stat);
		}
	}
}
