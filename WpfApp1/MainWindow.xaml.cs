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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        /* ///MAIN PAGE/// */

        private void btn_accept_Click(object sender, RoutedEventArgs e)
        {
            if(rb_se.IsChecked == true)
            {
                TabControlName.SelectedIndex = 1;
            }
            else if (rb_schul.IsChecked == true)
            {
                TabControlName.SelectedIndex = 2;
            }
        }

        private void rb_se_Checked(object sender, RoutedEventArgs e)
        {
            btn_accept.IsEnabled = true;
        }
        private void rb_schul_Checked(object sender, RoutedEventArgs e)
        {
            btn_accept.IsEnabled = true;
        }


        /* ///SE/SCHUL PAGE/// */
        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            TabControlName.SelectedIndex = 0;
        }


        /* ///SE PAGE/// */



        /* ///SCHUL PAGE/// */
    }
}
