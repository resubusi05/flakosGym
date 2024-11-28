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
    public partial class Perfil : Window
    {
        public Perfil()
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

        private void InformacionPersonal_Click(object sender, RoutedEventArgs e)
        {
            // Navega a InformaciónPersonal.xaml
            NavigationService.Navigate(new Uri("InformacionPersonal.xaml", UriKind.Relative));
        }

        private void Objetivo_Click(object sender, RoutedEventArgs e)
        {
            // Navega a Objetivo.xaml
            NavigationService.Navigate(new Uri("Objetivo.xaml", UriKind.Relative));
        }

    }
}