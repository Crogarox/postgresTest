using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace postgresTest
{
    public partial class Form1 : Form
    { 
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSQL_Click(object sender, EventArgs e)
        {
            try
            {
                var cs = txConnection.Text;
                NpgsqlConnection con = new NpgsqlConnection(cs);
                con.Open();
                var sql = txSqlQuery.Text;
                var cmd = new NpgsqlCommand(sql, con);
                //var version = cmd.ExecuteReader().ToString();
                //var version = cmd.ExecuteScalar().ToString();
                //Console.WriteLine($"PostgreSQL version: {version}");
                //rtbSqlOutput.Text = version;
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    //String groupz = rdr.GetString(0) == null        ? "" : rdr.GetString(0);
                    //String systemBarcode = rdr.GetString(1) == null ? "" : rdr.GetString(1);
                    //String cpuBarcode = rdr.GetString(2) == null    ? "" : rdr.GetString(2);
                    String groupz = "";
                    try { groupz = rdr.GetString(0); }
                    catch { groupz = ""; }
                    String systemBarcode = "";
                    try { systemBarcode = rdr.GetString(1); }
                    catch { systemBarcode = ""; }
                    String cpuBarcode = "";
                    try { cpuBarcode = rdr.GetString(2); }
                    catch { cpuBarcode = ""; }
                    rtbSqlOutput.Text = rtbSqlOutput.Text + "\n" + groupz + " " + systemBarcode + " " + cpuBarcode;
                    //Console.WriteLine("{0} {1} {2}", rdr.GetString(0), rdr.GetString(1), rdr.GetInt32(2));
                }
                con.Close();
                try
                {
                    // data adapter making request from our connection
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
                    // i always reset DataSet before i do
                    // something with it.... i don't know why :-)
                    ds.Reset();
                    // filling DataSet with result from NpgsqlDataAdapter
                    da.Fill(ds);
                    // since it C# DataSet can handle multiple tables, we will select first
                    dt = ds.Tables[0];
                    // connect grid to DataTable
                    dataGridView1.DataSource = dt;
                    // since we only showing the result we don't need connection anymore
                    con.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }

            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                //throw;
            }
        }
    }
}