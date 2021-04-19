using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace otherSol
{
    class Anywhere
    {
        public SqlConnection connection;

        public DataSet data;

        public SqlDataAdapter adapter;

        public void connect(Label connect)
        {
            SqlConnectionStringBuilder conSTR_base = new SqlConnectionStringBuilder();
            conSTR_base.DataSource = "192.168.2.7";
            conSTR_base.IntegratedSecurity = true;

            connection = new SqlConnection(conSTR_base.ToString());
            try
            {
                connection.Open();
                connect.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void adap_dat(string query)
        {
            try
            {
                adapter = new SqlDataAdapter(query, connection);
                data = new DataSet();
                adapter.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
