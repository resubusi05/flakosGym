using System.Data.SqlClient;
using System;
using System.Windows;
using System.Windows.Controls;

namespace flakosGym.Views
{
    public partial class RegisterView : Page
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
                // Conexi�n a la base de datos (ajusta la cadena de conexi�n)
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
                        command.Parameters.AddWithValue("@Password", password); // Nota: aseg�rate de encriptar las contrase�as.

                        command.ExecuteNonQuery();
                    }
                }

                // Mostrar mensaje de �xito
                MessageBox.Show("Cuenta creada exitosamente.", "�xito", MessageBoxButton.OK, MessageBoxImage.Information);

                // Redirigir a la p�gina de inicio
                NavigationService.Navigate(new Home());
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Ocurri� un error al crear la cuenta: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}