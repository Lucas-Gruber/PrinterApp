using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (rb_sankte.IsChecked == true)
            {
                SanktelisabethServerMenu sm = new SanktelisabethServerMenu();
                MainWindow wm = new MainWindow();
                this.Content = sm;
            }
            else if (rb_schul.IsChecked == true)
            {
                lbl_server.Content = "Du hast Schul03 gewählt";
            }
        }

        private void rb_server_checked(object sender, RoutedEventArgs e)
        {
            btn_accept.IsEnabled = true;
        }

        private void rb_se_Checked(object sender, RoutedEventArgs e)
        {
            btn_accept.IsEnabled = true;
            btn_accept.NavUri = "/SanktelisabethServerMenu.xaml";
        }

        private void btn_accept_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(btn_accept.NavUri);
        }

        private void rb_sankte_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void rb_schul_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
