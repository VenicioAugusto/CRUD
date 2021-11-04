using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_CRUD
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public Form1()
        {
            InitializeComponent();
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(@"Server=localhost;Database=venicio_sqldb;Uid=root;Pwd=simounao;");

                strSQL = "INSERT INTO VENICIO_SQLDB (NAME, NUMBER) VALUES (@NAME, @NUMBER)";

                command = new MySqlCommand(strSQL, connection);
                command.Parameters.AddWithValue("@NAME", txtName.Text); 
                command.Parameters.AddWithValue("@NUMBER", txtNumber.Text);

                connection.Open();
                command.ExecuteNonQuery();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(@"Server=localhost;Database=venicio_sqldb;Uid=root;Pwd=simounao;");

                strSQL = "UPDATE VENICIO_SQLDB SET NAME = @NAME, NUMBER = @NUMBER WHERE ID = @ID";

                command = new MySqlCommand(strSQL, connection);
                command.Parameters.AddWithValue("@ID", txtID.Text);
                command.Parameters.AddWithValue("@NAME", txtName.Text);
                command.Parameters.AddWithValue("@NUMBER", txtNumber.Text);

                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(@"Server=localhost;Database=venicio_sqldb;Uid=root;Pwd=simounao;");

                strSQL = "DELETE FROM VENICIO_SQLDB WHERE ID = @ID";

                command = new MySqlCommand(strSQL, connection);
                command.Parameters.AddWithValue("@ID", txtID.Text);

                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void Consultbtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(@"Server=localhost;Database=venicio_sqldb;Uid=root;Pwd=simounao;");

                strSQL = "SELECT * FROM VENICIO_SQLDB WHERE ID = @ID";

                command = new MySqlCommand(strSQL, connection);
                command.Parameters.AddWithValue("@ID", txtID.Text);

                connection.Open();
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    txtName.Text = Convert.ToString(dr["name"]);
                    txtNumber.Text = Convert.ToString(dr["number"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void Displaybtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(@"Server=localhost;Database=venicio_sqldb;Uid=root;Pwd=simounao;");

                strSQL = "SELECT * FROM VENICIO_SQLDB";

                da = new MySqlDataAdapter(strSQL, connection);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvData.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
        }
    }
}
