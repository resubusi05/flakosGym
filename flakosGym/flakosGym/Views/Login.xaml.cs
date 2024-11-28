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

using System.Data.SqlClient;

namespace flakosGym.Views
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnClose_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            Window ownerWindow = Window.GetWindow(this);
            ownerWindow.WindowState = WindowState.Minimized;
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (TextBoxPassword != null && PasswordBox != null &&
                TextBoxPassword.Visibility == Visibility.Visible)
            {
                TextBoxPassword.Text = PasswordBox.Password;
            }
        }

        private void BtnShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            PasswordBox.Visibility = Visibility.Collapsed;
            TextBoxPassword.Visibility = Visibility.Visible;
            TextBoxPassword.Text = PasswordBox.Password;

            // Cambiar la opacidad de la imagen al mostrar la contraseña
            if (BtnShowPassword.Content is Image image)
            {
                image.Opacity = 1.0;
                // Cambiar la imagen a "closed-eye.png"
                image.Source = new BitmapImage(new Uri("/Images/closed-eye.png"));
            }
        }

        private void BtnShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordBox.Password = TextBoxPassword.Text;
            PasswordBox.Visibility = Visibility.Visible;
            TextBoxPassword.Visibility = Visibility.Collapsed;

            // Cambiar la opacidad de la imagen al ocultar la contraseña
            if (BtnShowPassword.Content is Image image)
            {
                image.Opacity = 0.5;
                // Cambiar la imagen de vuelta a "eye.png"
                image.Source = new BitmapImage(new Uri("/Images/eye.png"));
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnIniciarSesion_OnClick(object sender, RoutedEventArgs e)
        {
            string connectionString = "Data Source=RESUBUSI05\\VSGESTION;Initial Catalog=FlakosGym;Integrated Security=True;";
            string query = "SELECT COUNT(*) FROM User WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", NombreUsuarioTextBox.Text);
                    command.Parameters.AddWithValue("@Password", PasswordBox.Password);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                        // Aquí puedes redirigir a la siguiente ventana
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        Close();
                    }
                    else
                    {
                        ErrorMessage.Text = "Usuario o contraseña incorrectos.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void hipervinculoCrearCuenta(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
