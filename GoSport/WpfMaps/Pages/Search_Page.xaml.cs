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
using BLL;
using BLL.BLL_DTO;
namespace WpfMaps
{
    /// <summary>
    /// Interaction logic for Search_Page.xaml
    /// </summary>
    public partial class Search_Page : Page
    {
        BLL_Data _bll = new BLL_Data();
        public Search_Page()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
           


        }



    }
}
