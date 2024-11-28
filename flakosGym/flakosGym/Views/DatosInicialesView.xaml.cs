using flakosGym.Models;
using flakosGym.Repositories;
using System.Windows;
using System.Xml.Linq;
using System;

namespace flakosGym.Views
{
    public partial class DatosInicialesView : Window
    {
        private readonly IUserRepository _userRepository;

        public DatosInicialesView()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void btnGuardarDatos_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                // Obtén los datos desde los controles del formulario
                string username = Username.Text;
                string password = txtPassword.Password;
                string name = txtName.Text;
                string lastName = txtLastName.Text;
                string email = txtEmail.Text;
                string objetivo = txtObjective.Text;
                DateTime birthDate = dpBirthDate.SelectedDate ?? DateTime.MinValue;
                string gender = cbGender.SelectedItem?.ToString();
                string phone = txtPhone.Text;

                // Validaciones (opcional)
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

                // Crea el modelo de usuario
                var newUser = new UserModel
                {
                    Username = username,
                    Password = password,
                    Name = name,
                    LastName = lastName,
                    Email = email,
                    Obejetivo = objetivo,
                    FechaDeNacimiento = birthDate.ToString("yyyy-MM-dd"),
                    Genero = gender,
                    Telefono = phone
                };

                // Guarda el usuario en la base de datos
                _userRepository.add(newUser);

                // Mensaje de éxito
                MessageBox.Show("Usuario guardado exitosamente.");
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Error al guardar usuario: {ex.Message}");
            }
        }
    }
}
