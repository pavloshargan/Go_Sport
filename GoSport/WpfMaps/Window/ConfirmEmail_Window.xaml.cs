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

namespace WpfMaps
{
    /// <summary>
    /// Interaction logic for ConfirmEmail_Window.xaml
    /// </summary>
    public partial class ConfirmEmail_Window : Window
    {
        public ConfirmEmail_Window()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }




    }
}
