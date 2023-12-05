using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace crmSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }
        private void ButtonLoginClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Авторизация в приложении находится в разработке!", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void HyperlinkLoginGuestClick(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }
        private void HyperlinkRegistrationClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Регистрация в приложении находится в разработке!", "Регистрация", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}