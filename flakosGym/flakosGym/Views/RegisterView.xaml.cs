using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace flakosGym.Views
{
    public partial class RegisterView : Window
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void BtnClose_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }


        private void BtnCrearCuenta(object sender, RoutedEventArgs e)
        {
            // Validar los campos de entrada
            string nombre = TextBoxNombre.Text.Trim();
            string apellido = TextBoxApellido.Text.Trim();
            string username = TextBoxUserName.Text.Trim();
            string email = TextBoxEmail.Text.Trim();
            string password = PasswordBox.Password;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                // Conexión a la base de datos (ajusta la cadena de conexión)
                string connectionString = "Data Source=RESUBUSI05\\VSGESTION;Initial Catalog=FlakosGym;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insertar datos en la tabla de usuarios
                    string query = "INSERT INTO User (Name, LastName, Username, Email, Password) " +
                                   "VALUES (@Name, @LastName, @Username, @Email, @Password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", nombre);
                        command.Parameters.AddWithValue("@LastName", apellido);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password); // Nota: asegúrate de encriptar las contraseñas.

                        command.ExecuteNonQuery();
                    }
                }

                // Mostrar mensaje de éxito
                MessageBox.Show("Cuenta creada exitosamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

                // Redirigir a la página de inicio (abrir la ventana Home y cerrar la ventana actual)
                var homeWindow = new Home();  // Crear una nueva instancia de la ventana de inicio
                homeWindow.Show();            // Mostrar la ventana de inicio
                this.Close();                 // Cerrar la ventana de registro actual
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Ocurrió un error al crear la cuenta: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}