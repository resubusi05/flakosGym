using System;
using System.Windows;
using System.Windows.Controls;

namespace flakosGym.Views
{
    public partial class DatosInicialesView : Window
    {
        public DatosInicialesView()
        {
            InitializeComponent();
        }

        private void btnGuardarDatos_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                // Obtener los valores ingresados por el usuario
                ComboBox comboBoxGenero = (ComboBox)FindName("ComboBoxGenero");
                TextBox textBoxEdad = (TextBox)FindName("TextBoxEdad");
                TextBox textBoxTelefono = (TextBox)FindName("TextBoxTelefono");
                TextBox textBoxPeso = (TextBox)FindName("TextBoxPeso");

                string genero = (comboBoxGenero.SelectedItem as ComboBoxItem)?.Content.ToString() ?? "";
                string edad = textBoxEdad?.Text.Trim() ?? "";
                string numeroTelefono = textBoxTelefono?.Text.Trim() ?? "";
                string peso = textBoxPeso?.Text.Trim() ?? "";

                // Validar los datos
                if (string.IsNullOrEmpty(genero) || string.IsNullOrEmpty(edad) || string.IsNullOrEmpty(numeroTelefono) || string.IsNullOrEmpty(peso))
                {
                    MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (!int.TryParse(edad, out int edadNumerica))
                {
                    MessageBox.Show("La edad debe ser un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (!decimal.TryParse(peso, out decimal pesoDecimal))
                {
                    MessageBox.Show("El peso debe ser un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Guardar los datos (puedes reemplazar esto con la lógica para guardar en la base de datos)
                MessageBox.Show($"Datos guardados:\nGénero: {genero}\nEdad: {edadNumerica}\nTeléfono: {numeroTelefono}\nPeso: {pesoDecimal} kg",
                                "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar los datos: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
