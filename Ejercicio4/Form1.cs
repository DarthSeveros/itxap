using MySql.Data.MySqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        Matrix matrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, m;
            try
            {
                m = Convert.ToInt32(inputRows.Text);
                n = Convert.ToInt32(inputCols.Text);
                if (m < 1 || m >= 1000 || n < 1 || n >= 1000)
                {
                    throw new Exception();
                }
                matrix = new Matrix(m, n);
                labelMatrix.Text = matrix.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa valores válidos");
            }
            catch
            {
                errorLabel.Text = "Valores entre 1 y 1000";
            }

        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Necesitas generar una matriz");
                return;
            }
            matrix.sort();
            labelMatrix.Text = matrix.ToString();

        }


        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Necesitas generar una matriz");
                return;
            }
            matrix.reverse();
            labelMatrix.Text = matrix.ToString();
        }

        private void labelMatrix_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            string database = "ejercicio4";
            string user = "root";
            string password = "";
            string server = "localhost";
            string port = "3306";

            string MyConString = $"server={server};port={port};database={database};uid={user};pswd={password};";

            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Error al conectarse a la base de datos");
                connection.Close();
                return;
            }
            
            command.CommandText = "create table if not exists matrices(id int unsigned auto_increment not null primary key, matriz longtext);";
            command.ExecuteNonQuery();
            if (matrix == null)
            {
                MessageBox.Show("Necesitas generar una matriz");
                return;
            }
            else
            {
                string saveMatrix = matrix.ToSaveDB();
                command.CommandText = $"insert into matrices(matriz) values('{saveMatrix}')";
                command.ExecuteNonQuery();
            }
            
            connection.Close();
        }
    }
}