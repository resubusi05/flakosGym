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
using flakosGym.Models;


namespace flakosGym.Views
{
    public partial class RegisterView : Window
    {

        private readonly string _connectionString;

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


        private void BtnGuardarDatosDeCuenta(object sender, RoutedEventArgs e)
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
                // Crear una instancia del modelo con los datos del formulario
                var user = new UserModel
                {
                    Name = nombre,
                    LastName = apellido,
                    Username = username,
                    Email = email,
                    Password = password // Nota: Asegúrate de encriptar la contraseña
                };

                // Agregar el usuario a través del repositorio
                _userRepository.add(user);

                // Mostrar mensaje de éxito
                MessageBox.Show("Cuenta creada exitosamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

                // Redirigir a la página de inicio
                var homeWindow = new Home(); // Crear una nueva instancia de la ventana de inicio
                homeWindow.Show();           // Mostrar la ventana de inicio
                this.Close();                // Cerrar la ventana de registro actual
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Ocurrió un error al crear la cuenta: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}