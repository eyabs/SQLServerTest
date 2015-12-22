using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLServerTest
{
    public partial class Pathfinder : Form
    {
        public Pathfinder()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = @"Server=ERICT440S\SQLEXPRESS; Database=d20; User Id=velociraptor; Password=velociraptor";

                using (SqlConnection SQLConnection = new SqlConnection(connStr))
                {
                    SQLConnection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = SQLConnection;
                    cmd.CommandText = "SELECT * FROM Pathfinder.Spells";

                    using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable data = new DataTable();
                        adapter.Fill(data);

                        dgvSpells.DataSource = data;
                    }
                    

                    txtLog.Text += String.Format("State: {0}", SQLConnection.State);
                    txtLog.Refresh();
                }

                    
                MessageBox.Show("Success!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(String.Format("Error!: {0}" , ex.ToString()));
            }
        }
    }
}
