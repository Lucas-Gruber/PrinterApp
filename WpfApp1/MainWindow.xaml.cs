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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(rb_sankte.IsChecked == true)
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
            btn_next.IsEnabled = true;
        }
    }
}
