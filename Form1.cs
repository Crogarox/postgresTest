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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            var cs = txConnection.Text;

            NpgsqlConnection con = new NpgsqlConnection(cs);
            con.Open();

            var sql = txSqlQuery.Text;

            var cmd = new NpgsqlCommand(sql, con);

            var version = cmd.ExecuteScalar().ToString();
            Console.WriteLine($"PostgreSQL version: {version}");
            rtbSqlOutput.Text = $"PostgreSQL version: {version}";

        }
    }
}
