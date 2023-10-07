using MySql.Data.MySqlClient;
using System.Data;

namespace MySQLconexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            string host = txthost.Text;
            string user = txtUsuario.Text;
            string password = txtcontrasena.Text;
            string puerto = txtpuerto.Text;
            string database = txtbasededatos.Text;

            string connectionString = BuildConnectionString(host, user, password, puerto, database);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM CatPersonal", con);
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT * FROM CatProducto", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    adapter2.Fill(dt);
                    dgvDatos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                }
            }
        }

        private string BuildConnectionString(string host, string user, string password, string port, string database)
        {
            return $"SERVER={host};PORT={port};DATABASE={database};USER ID={user};PASSWORD={password};";
        }
    }
}