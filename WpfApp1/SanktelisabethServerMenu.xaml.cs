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
    /// Interaktionslogik für SanktelisabethServerMenu.xaml
    /// </summary>
    public partial class SanktelisabethServerMenu : Page
    {
        public SanktelisabethServerMenu()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            btn_install.IsEnabled = true;
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            btn_install.IsEnabled = false;
        }

        private void btn_install_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
