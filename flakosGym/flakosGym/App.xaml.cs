using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using flakosGym.Views;
//using Microsoft.UI.Xaml.Controls;
//using Microsoft.UI.Xaml.Navigation;
using System;
//using WindowsHelloLogin.Views;

namespace flakosGym
{
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            var loginView = new Login();
            loginView.IsVisibleChanged += (s, ev) =>
            {
                if (!loginView.IsVisible && loginView.IsLoaded)
                {
                    var mainView = new MainWindow();
                    mainView.Show();
                    loginView.Close();
                }
            };
            loginView.Show();  // Asegúrate de mostrar la ventana
        }
        
    }
}
